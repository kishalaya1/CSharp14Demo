// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using CSharp14Demo;
using CSharp14Demo.Entities;


Console.WriteLine("Hello, World!");
//PrintExtensionMembersDemo();
//ExtensionCompleteExampleDemo()
Demo();
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
    Console.WriteLine($"Developer Name: {dev.Name}");
    Console.WriteLine($"Rate Per Hour: {dev.RatePerHour}");
    Console.WriteLine($"Years Of Experience: {dev.YearsOfExperience}");
    Console.WriteLine($"Category: {dev.Category}");
    Console.WriteLine($"Created Date: {dev.CreatedDate}");
    int experience = 3;
    bool isSenior = Developer.IsSeniorDeveloper(experience);
    Console.WriteLine($"Is developer with {experience} years of experience a senior developer? {isSenior}");
    Console.WriteLine($"Default Category: {Developer.DefaultCategory}");
}

static void Demo()
{
    //use this function to write any code and test new C# 14.0 features

}
Console.ReadKey();