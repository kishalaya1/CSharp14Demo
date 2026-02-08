// See https://aka.ms/new-console-template for more information
using CSharp14Demo;
using CSharp14Demo.Entities;
using System;
using System.Text.RegularExpressions;


Console.WriteLine("Hello, World!");
//PrintExtensionMembersDemo();
//ExtensionCompleteExampleDemo();
//NullAssignmentDemo();
//DemoOldFieldExample();
//LambdaParamDemo();
//UnboundGenericNameOfDemo();
//SpanImplicitConversionDemo();
//PartialEventsandConstructorsDemo();
UserDefinedCompoundAssignmentOperatorsDemo();
//Demo();
static void PrintExtensionMembersDemo()
{
    var examples = new[]
      {
        "Hello, World! @2026 #CSharp",
        "This-is_a/test:with;special$chars%&",
        "Normal Text 123",
        string.Empty,
        null
    };
    Console.WriteLine("Remove Special character demo start!");
    foreach (var s in examples)
    {
        var cleaned = s?.RemoveSpecialCharacters() ?? string.Empty;
        Console.WriteLine($"Original : {s ?? "<null>"}");
        Console.WriteLine($"Cleaned  : {cleaned}");
        Console.WriteLine();
    }
    Console.WriteLine("Remove Special character demo end!");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Clip characters demo start");
    foreach (var s in examples)
    {
        var cleaned = s?.ClipStart(4) ?? string.Empty;
        Console.WriteLine($"Original : {s ?? "<null>"}");
        Console.WriteLine($"Clipped String  : {cleaned}");
        Console.WriteLine();
    }
    Console.WriteLine("Clip characters demo end");
    Console.WriteLine("----------------------------------");
    Console.WriteLine("Character count demo start");
    foreach (var s in examples)
    {
        var count = s?.CharacterCount ?? 0;
        Console.WriteLine($"Original : {s ?? "<null>"}");
        Console.WriteLine($"Character Count  : {count}");
        Console.WriteLine();
    }
    Console.WriteLine("Character count demo end");

}

static void ExtensionCompleteExampleDemo()
{
    var dev = Developer.CreateDefault();
    dev.YearsOfExperience = 20;
    dev.Category = "Vibe Coder";
    Console.WriteLine($"Developer Name: {dev.Name}");
    Console.WriteLine($"Rate Per Hour: {dev.RatePerHour}");
    Console.WriteLine($"Years Of Experience: {dev.YearsOfExperience}");
    Console.WriteLine($"Category: {dev.Category}");
    Console.WriteLine($"Created Date: {dev.CreatedDate}");
    int experience = 3;
    bool isSenior = Developer.IsSeniorDeveloper(experience);
    Console.WriteLine($"Is developer with {experience} years of experience a senior developer? {isSenior}");
    Console.WriteLine($"Is the developer a Pseudo ? {(Developer.IsPsuedoDeveloper(dev) ? "Yes" : "No")}");
    Console.WriteLine($"Default Category: {Developer.DefaultCategory}");
}

static void NullAssignmentDemo()
{
    Console.WriteLine("Null assignment demo start!");
    NullAssignmentExample.NullAssignmentDemo();
    Console.WriteLine("Null assignment demo end!");
}   
static void DemoOldFieldExample()
{
    Console.WriteLine("field keyword demo start!");
    FieldExample.Demo();
    Console.WriteLine("field keyword demo end!");
}
static void LambdaParamDemo()
{
    Console.WriteLine("Lambda parameters demo start!");
    LambdaParamExample.Demo();
    Console.WriteLine("Lambda parameters demo end!");
}
static void UnboundGenericNameOfDemo()
{
    Console.WriteLine("Unbound generic nameof demo start!");
    UnboundGenericNameOfExample.Demo();
    Console.WriteLine("Unbound generic nameof demo end!");
}
static void SpanImplicitConversionDemo()
{
    Console.WriteLine("Span<T> / ReadOnlySpan<T> implicit conversions demo start!");
    SpanImplicitConversionExample.Demo();
    Console.WriteLine("Span<T> / ReadOnlySpan<T> implicit conversions demo end!");
}
static void PartialEventsandConstructorsDemo()
{
    Console.WriteLine("Partial events and constructors demo start!");
    PartialEventsandConstructors.Demo();
    Console.WriteLine("Partial events and constructors demo end!");
}
static void UserDefinedCompoundAssignmentOperatorsDemo()
{
    Console.WriteLine("---User defined compound assignment operators demo start!---");
    UserDefinedCompundAssignmentExample.Demo();
    Console.WriteLine("---User defined compound assignment operators demo end!---");
}
static void Demo()
{
    //use this function to write any code and test new C# 14.0 features

}
Console.ReadKey();