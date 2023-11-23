using NativeWebApi.Entities;

namespace NativeWebApi.Data;

public static class TodoDb
{
    private static readonly List<Todo> _todos =
    [
        new(1, "Walk the dog"),
        new(2, "Do the dishes", DateOnly.FromDateTime(DateTime.Now)),
        new(3, "Do the laundry", DateOnly.FromDateTime(DateTime.Now.AddDays(1))),
        new(4, "Clean the bathroom"),
        new(5, "Clean the car", DateOnly.FromDateTime(DateTime.Now.AddDays(2))),
        new(6, "Buy groceries"),
        new (7, "Mow the lawn", DateOnly.FromDateTime(DateTime.Now.AddDays(3))),
        new (8, "Take out the trash"),
        new (9, "Make dinner", DateOnly.FromDateTime(DateTime.Now.AddDays(4)))
    ];

    public static Task<Todo[]> GetTodosAsync() => Task.FromResult(_todos.ToArray());

    public static Task<Todo?> GetTodoAsync(int id) =>
        Task.FromResult(_todos.FirstOrDefault(a => a.Id == id));

    public static Task<Todo> AddTodoAsync(Todo todo)
    {
        if (todo.Id == 0)
        {
            todo = todo with { Id = _todos.Max(a => a.Id) + 1 };
        }
        else if (_todos.Any(a => a.Id == todo.Id))
        {
            throw new InvalidOperationException("Todo already exists");
        }

        _todos.Add(todo);
        return Task.FromResult(todo);
    }

    public static Task<Todo?> UpdateTodoAsync(Todo todo)
    {
        var index = _todos.FindIndex(a => a.Id == todo.Id);
        if (index == -1)
        {
            return Task.FromResult((Todo?) null);
        }

        var newTodo = _todos[index] with
        {
            Title = todo.Title,
            DueBy = todo.DueBy,
            IsComplete = todo.IsComplete
        };
        _todos[index] = newTodo;

        return Task.FromResult(newTodo)!;
    }

    public static Task<bool> DeleteTodoAsync(int id)
    {
        var index = _todos.FindIndex(a => a.Id == id);
        if (index == -1)
        {
            return Task.FromResult(false);
        }

        _todos.RemoveAt(index);
        return Task.FromResult(true);
    }
}
