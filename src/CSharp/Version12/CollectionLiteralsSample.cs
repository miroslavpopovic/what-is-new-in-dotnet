namespace CSharp.Version12;

public static class CollectionLiteralsSample
{
    public static void Run()
    {
        List<int> list = [1, 2, 3];
        int[] array1 = [1, 2, 3];
        int[] array2 = [4, 5];
        int[] array3 = [..array1, ..array2, 6];

        var stream = new MemoryStream([1, 2, 3, 4, 5]);

        Console.WriteLine($"List items count: {list.Count}");
        Console.WriteLine($"Array 1 length: {array1.Length}");
        Console.WriteLine($"Array 2 length: {array2.Length}");
        Console.WriteLine($"Array 3 length: {array3.Length}");
        Console.WriteLine($"Stream length: {stream.Length} bytes");
    }
}
