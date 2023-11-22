namespace CSharp.Version11;

// Up to C# 10
[AttributeUsage(AttributeTargets.Class)]
public class TypeAttribute(Type type) : Attribute
{
    public Type Type { get; } = type;
}

// C# 11
[AttributeUsage(AttributeTargets.Class)]
public class GenericTypeAttribute<T> : Attribute;

[Type(typeof(string))]
[GenericType<string>]
public class AttributedClass;

public static class GenericAttributesSample
{
    public static void Run()
    {
        var attributes = string.Join(
            ", ", typeof(AttributedClass).GetCustomAttributes(false).Select(x => x.GetType().Name));
        Console.WriteLine("    Attributes applied to the class: " + attributes);
    }
}
