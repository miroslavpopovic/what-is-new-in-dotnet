using System.Text.Json;
using System.Text.Json.Serialization;

namespace LibraryApis.DotNet8;

[JsonUnmappedMemberHandling(JsonUnmappedMemberHandling.Disallow)]
public record Product(int Id, string Name);

public static class JsonMissingMembersHandlingSample
{
    public static void Run()
    {
        const string serializedProduct1 = """{"Id": 1, "Name": "mobile phone"}""";
        const string serializedProduct2 = """{"Id": 2, "Name": "laptop", "Price": 300}""";

        try
        {
            var product1 = JsonSerializer.Deserialize<Product>(serializedProduct1);
            Console.WriteLine($"Deserialized product 1: {product1}");

            var product2 = JsonSerializer.Deserialize<Product>(serializedProduct2);
            Console.WriteLine($"Deserialized product 1: {product2}");
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"Error deserializing product: {ex.Message}");
        }
    }
}
