// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;
using CSharp14Demo;

Console.WriteLine("Hello, World!");
//PrintExtensionMembersDemo();
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

}


static void Demo()
{
    //use this function to write any code and test new C# 14.0 features

}
Console.ReadKey();