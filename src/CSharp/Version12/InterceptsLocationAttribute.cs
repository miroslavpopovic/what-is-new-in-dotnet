#pragma warning disable CS9113 // Parameter is unread.
// ReSharper disable once CheckNamespace
namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Method)]
public sealed class InterceptsLocationAttribute(
    string filePath, int line, int character) : Attribute;
