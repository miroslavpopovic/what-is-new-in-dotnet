namespace CSharp.Version12;

using Point2d = (int X, int Y);
using IntStringDictionary = Dictionary<int, string>;
using IntArray = int[];
using DbInt = int?;

public static class AliasAnyTypeSample
{
    public static void Run()
    {
        var point2d = new Point2d(2, 6);
        var point2d2 = (3, 7);

        var dictionary = new IntStringDictionary { { 1, "One" }, { 2, "Two" } };

        var intArray = new IntArray[3];
        DbInt dbInt = 4;

        Console.WriteLine($"Point 1: {point2d}");
        Console.WriteLine($"Point 2: {point2d2}");
        Console.WriteLine($"Dictionary items count: {dictionary.Count}");
        Console.WriteLine($"Int array count: {intArray.Length}");
        Console.WriteLine($"Int value: {dbInt}");

        // Nick Chapsas: The most confusing C# 12 feature yet
        // https://www.youtube.com/watch?v=4GeEvcKq8Lo
    }
}
