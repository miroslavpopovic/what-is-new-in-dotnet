// See https://aka.ms/new-console-template for more information

using CSharp.Version11;
using CSharp.Version12;

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-11
Console.WriteLine();
Console.WriteLine("*** C# 11 FEATURES (.NET 7) ***");

Console.WriteLine("11-01. Raw string literals and interpolation improvements");
RawStringLiteralsSample.Run();

Console.WriteLine("11-02. Generic attributes");
GenericAttributesSample.Run();

Console.WriteLine("11-03. Auto-default structs and file-scoped types");
AutoDefaultStructsSample.Run();

Console.WriteLine("11-04. List and string patterns");
ListAndStringPatternsSample.Run();

Console.WriteLine("11-05. Required members");
RequiredMembersSample.Run();

// https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
Console.WriteLine();
Console.WriteLine("*** C# 12 FEATURES (.NET 8) ***");

Console.WriteLine("12-01. Primary constructors");
PrimaryConstructorsSample.Run();

Console.WriteLine("12-02. Alias any type");
AliasAnyTypeSample.Run();

Console.WriteLine("12-03. Optional and parameter array parameters for lambdas and method groups");
LambdaParametersSample.Run();

Console.WriteLine("12-04. Collection expressions");
CollectionLiteralsSample.Run();

Console.WriteLine("12-05. Interceptors (experimental)");
InterceptorsSample.Run();

//Console.Read();
