using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.HttpResults;
using NativeWebApi.Data;
using NativeWebApi.Entities;

var builder = WebApplication.CreateSlimBuilder(args);

builder.AddServiceDefaults();

builder.Services.ConfigureHttpJsonOptions(options =>
{
    options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
});

var app = builder.Build();

app.MapDefaultEndpoints();

var todosApi = app.MapGroup("/todos");

todosApi.MapGet("/", TodoDb.GetTodosAsync);

static async Task<Results<Ok<Todo>, NotFound>> GetTodoAsync(int id)
{
    var todo = await TodoDb.GetTodoAsync(id);

    return todo is not null
        ? TypedResults.Ok(todo)
        : TypedResults.NotFound();
}

todosApi.MapGet("/{id}", GetTodoAsync);

static async Task<Created<Todo>> AddTodoAsync(Todo todo)
{
    var newTodo = await TodoDb.AddTodoAsync(todo);
    return TypedResults.Created($"/todos/{newTodo.Id}", newTodo);
}

todosApi.MapPost("/", AddTodoAsync);

static async Task<Results<Ok<Todo>, ValidationProblem, NotFound>> UpdateTodoAsync(
    int id, Todo todo)
    {
        if (id != todo.Id)
        {
            return TypedResults.ValidationProblem(
                new Dictionary<string, string[]> {{"id", new[] {"Id mismatch"}}});
        }

        var updatedTodo = await TodoDb.UpdateTodoAsync(todo);

        return updatedTodo is not null
            ? TypedResults.Ok(updatedTodo)
            : TypedResults.NotFound();
    };

todosApi.MapPut("/{id}", UpdateTodoAsync);

static async Task<Results<Ok, NotFound>> DeleteTodoAsync(int id)
{
    var result = await TodoDb.DeleteTodoAsync(id);
    return result ? TypedResults.Ok() : TypedResults.NotFound();
}

todosApi.MapDelete("/{id}", DeleteTodoAsync);

app.Run();

[JsonSerializable(typeof(Todo[]))]
internal partial class AppJsonSerializerContext : JsonSerializerContext;
