// See https://aka.ms/new-console-template for more information

using LibraryApis.DotNet7;
using LibraryApis.DotNet8;

Console.WriteLine();
Console.WriteLine("*** New and improved BCL APIs in .NET 7 ***");

Console.WriteLine("7-01. Generic Math");
GenericMathSample.Run();

Console.WriteLine("7-02. Regular expression improvements");
RegexImprovementsSample.Run();

Console.WriteLine("7-03. Microseconds and nanoseconds for time");
MicrosecondsNanosecondsSample.Run();

Console.WriteLine("7-04. JSON polymorphism");
JsonPolymorphismSample.Run();

Console.WriteLine("7-05. JSON contract customization");
JsonContractCustomizationSample.Run();

Console.WriteLine();
Console.WriteLine("*** New and improved BCL APIs in .NET 8 ***");

Console.WriteLine("8-01. DataAnnotations improvements");
DataAnnotationsImprovementsSample.Run();

Console.WriteLine("8-02. TimeProvider");
TimeProviderSample.Run();

Console.WriteLine("8-03. JSON missing member handling");
JsonMissingMembersHandlingSample.Run();

Console.WriteLine("8-04. JSON snake_case and kebab-case serialization");
JsonSnakeAndKebabCasePropertiesSample.Run();

Console.Read();
