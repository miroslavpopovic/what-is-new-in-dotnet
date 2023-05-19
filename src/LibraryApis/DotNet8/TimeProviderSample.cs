namespace LibraryApis.DotNet8;

public class TestTimeProvider : TimeProvider
{
    public override DateTimeOffset GetUtcNow() =>
        new(2023, 5, 30, 14, 30, 0, TimeSpan.Zero);
}

public static class TimeProviderSample
{
    public static void Run()
    {
        Console.WriteLine("TimeProvider.System time - UTC Now: " + TimeProvider.System.GetUtcNow());

        var testTimeProvider = new TestTimeProvider();
        Console.WriteLine("TestTimeProvider time - UTC Now: " + testTimeProvider.GetUtcNow());
    }
}
