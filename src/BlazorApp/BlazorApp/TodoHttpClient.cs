namespace BlazorApp;

public class TodoHttpClient(HttpClient httpClient)
{
    public async Task<Todo[]> GetTodosAsync() => 
        (await httpClient.GetFromJsonAsync<Todo[]>("todos"))!;

    public async Task<Todo?> GetTodoAsync(int id) => 
        await httpClient.GetFromJsonAsync<Todo?>($"todos/{id}");

    public async Task<Todo> AddTodoAsync(Todo todo)
    {
        var response = await httpClient.PostAsJsonAsync("todos", todo);
        
        return (await response.Content.ReadFromJsonAsync<Todo>())!;
    }

    public async Task<Todo?> UpdateTodoAsync(Todo todo)
    {
        var response = await httpClient.PutAsJsonAsync($"todos/{todo.Id}", todo);
        return await response.Content.ReadFromJsonAsync<Todo>();
    }

    public async Task<bool> DeleteTodoAsync(int id)
    {
        var response = await httpClient.DeleteAsync($"todos/{id}");
        return response.IsSuccessStatusCode;
    }
}