using System.Runtime.CompilerServices;

namespace CSharp.Version12;

public static class InterceptorsSample
{
    public static void Run()
    {
        new Intercepted().Call("Hello World!");
    }
}

public class Intercepted
{
    public void Call(string text) => Console.WriteLine($"Original method call: {text}");
}

public static class Interceptor
{
    [InterceptsLocation(
        @"C:\Users\miros\source\github\what-is-new-in-dotnet-world\src\CSharp\Version12\InterceptorsSample.cs",
        9, 27)]
    public static void InterceptorCall(this Intercepted intercepted, string text) =>
        Console.WriteLine($"Interceptor takes over the call! {text}");
}
