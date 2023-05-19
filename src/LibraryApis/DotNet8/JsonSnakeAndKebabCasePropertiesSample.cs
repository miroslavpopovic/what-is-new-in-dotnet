using System.Text.Json;

namespace LibraryApis.DotNet8;

public record ContactInfo(int ContactId, string PersonName, string PrimaryAddress, string PrimaryPhone);

public static class JsonSnakeAndKebabCasePropertiesSample
{
    public static void Run()
    {
        var contactInfo = new ContactInfo(1, "Dylan Dog", "Craven Road", "01 555 666-6666");
        var snakeCaseOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower };
        var kebabCaseOptions = new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.KebabCaseLower };

        var snakeCaseResult = JsonSerializer.Serialize(contactInfo, snakeCaseOptions);
        Console.WriteLine($"Serialized to snake_case: {snakeCaseResult}");

        var kebabCaseResult = JsonSerializer.Serialize(contactInfo, kebabCaseOptions);
        Console.WriteLine($"Serialized to kebab-case: {kebabCaseResult}");
    }
}
