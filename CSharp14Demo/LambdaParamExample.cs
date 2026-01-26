using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo
{
    public class LambdaParamExample
    {
        public static void Demo()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Existing examples
            var squaresExplicit = numbers.ConvertAll((int x) => x * x);
            Console.WriteLine("Squares with explicit parameter type: " + string.Join(", ", squaresExplicit));

            var squaresInferred = numbers.ConvertAll(x => x * x);
            Console.WriteLine("Squares with inferred parameter type: " + string.Join(", ", squaresInferred));

            // Alternate examples using implicit parameter types (type inferred by the compiler)

            // 1) Assign a lambda to a Func<T, TResult> — parameter type is implicit
            Func<int, int> squareFunc = x => x * x;
            Console.WriteLine("squareFunc(6): " + squareFunc(6));

            // 2) List<T>.ForEach with an implicit param to perform an action
            Console.Write("Numbers printed with implicit param: ");
            numbers.ForEach(n => Console.Write(n + " "));
            Console.WriteLine();

            // 3) Predicate lambdas with implicit param types
            var evens = numbers.FindAll(n => n % 2 == 0);
            Console.WriteLine("Evens: " + string.Join(", ", evens));

            // 4) Multi-parameter lambda with inferred types for comparison/sorting
            var names = new List<string> { "Neo", "Morpheus", "Trinity" };
            names.Sort((a, b) => a.CompareTo(b));
            Console.WriteLine("Sorted names: " + string.Join(", ", names));

            // 5) Action with two parameters: print a text multiple times
            Console.WriteLine("action with two params implicit example-print a text multiple times ");
            Action<string, int> repeat = (text, count) =>
            {
                for (int i = 0; i < count; i++)
                    Console.Write(text);
                Console.WriteLine();
            };
            Console.Write("repeat(\"Hi \", 3) -> ");
            repeat("Hi ", 3);
            // Action with explicit parameter type
            Console.WriteLine("action with two params explicit example-print a text multiple times ");
            Action<string, int> repeatExplicit = (string text, int count) =>
            {
                for (int i = 0; i < count; i++)
                    Console.Write(text);
                Console.WriteLine();
            };
            Console.Write("repeatExplicit(\"Hi \", 3) -> ");
            repeatExplicit("Hi Explicit ", 3);
            Console.WriteLine();
            Console.WriteLine("=== Simple multi-parameter lambda examples (no collections) ===");

            // Simple multiple-parameter examples without collections
            // Parameter types are implicit because they're inferred from the delegate type (Func/Action)

            // Add two integers
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine($"add(2, 3) = {add(2, 3)}");

            // Multiply two doubles
            Func<double, double, double> multiply = (x, y) => x * y;
            Console.WriteLine($"multiply(2.5, 4) = {multiply(2.5, 4)}");

            // Compute power using Math.Pow (both parameters inferred as double)
            Func<double, double, double> power = (baseVal, exponent) => Math.Pow(baseVal, exponent);
            Console.WriteLine($"power(2, 3) = {power(2, 3)}");

            // Concatenate two strings
            Func<string, string, string> concat = (left, right) => left + right;
            Console.WriteLine($"concat(\"Hello \", \"World\") = {concat("Hello ", "World")}");

           

        }
    }
}
