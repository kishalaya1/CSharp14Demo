using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo
{
    public class UnboundGenericNameOfExample
    {
        public static void Demo()
        {
            // Using nameof with an unbound generic type
            string listName = nameof(List<>);
            string dictionaryName = nameof(Dictionary<,>);
            string stringBuilderName = nameof(StringBuilder);
            Console.WriteLine($"Unbound generic type name: {listName}");
            Console.WriteLine($"Unbound generic type name: {dictionaryName}");
            Console.WriteLine($"Non-generic type name: {stringBuilderName}");
        }
    }
}
