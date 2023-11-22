// ReSharper disable ConvertToLocalFunction
namespace CSharp.Version12;

public static class LambdaParametersSample
{
    public static void Run()
    {
        var addWithDefault = (int addTo = 2) => addTo + 1;
        Console.WriteLine($"Lambda with default value: {addWithDefault()}");
        Console.WriteLine($"Lambda with provided parameter value: {addWithDefault(5)}");
        Console.WriteLine($"Parameter group with default value: {AddWithDefaultMethod()}");
        Console.WriteLine($"Parameter group with provided parameter value: {AddWithDefaultMethod(8)}");

        var counter = (params int[] xs) => xs.Length;
        Console.WriteLine($"Lambda with no params: {counter()}");
        Console.WriteLine($"Lambda with provided params array: {counter(1, 2, 3)}");
        Console.WriteLine($"Parameter group with no params: {CountMethod()}");
        Console.WriteLine($"Parameter group with provided params array: {CountMethod(1, 2, 3, 6)}");
    }

    private static int AddWithDefaultMethod(int addTo = 2) => addTo + 1;
    private static int CountMethod(params int[] xs) => xs.Length;
}
