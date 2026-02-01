using System;

namespace CSharp14Demo
{
    public class SpanImplicitConversionExample
    {
        public static void Demo()
        { 
            // 1) Array -> Span<T> (implicit)
            int[] luckyNos = { 9, 13, 22, 24, 27,59,67,53 };
            Span<int> spanFromArray = luckyNos; // implicit conversion
            ReadOnlySpan<int> roFromArray = luckyNos; // implicit conversion to ReadOnlySpan<T>

            Console.Write("Original array: ");
            Print(roFromArray);

            // Mutate via Span<T> and show array is updated 
            spanFromArray[1] = 20;
            Console.Write("After spanFromArray[1] = 20 -> array: ");
            Print(roFromArray);

            // 2) Span<T> -> ReadOnlySpan<T> (implicit)
            ReadOnlySpan<int> roFromSpan = spanFromArray;// implicit, safe read-only view
            Console.Write("ReadOnlySpan from Span: ");
            Print(roFromSpan);

            // 3) string -> ReadOnlySpan<char> (implicit)
            string message = "Hello, this is span implicit conversion in C# 14!";
            ReadOnlySpan<char> chars = message; // implicit conversion from string
            Console.WriteLine($"Original string: {message}");
            Console.WriteLine($"Substring via ReadOnlySpan<char>.Slice(7,4): \"{chars.Slice(7, 4).ToString()}\"");

            // 4) stackalloc -> Span<T> (stack-allocated memory)
            Span<int> stackSpan = stackalloc int[] { 10, 30, 40 }; //implicit span from stackalloc
            Console.Write("Stack allocated span values: ");
            Print(stackSpan);

            // ReadOnlySpan from stack-allocated Span (implicit)
            ReadOnlySpan<int> roStack = stackSpan;
            Console.Write("ReadOnlySpan from stack allocated span: ");
            Print(roStack);

            // 5) Get a Span from array using AsSpan (explicit helper) and show slicing
            Span<int> slice = luckyNos.AsSpan(2, 3); // creates a Span over elements [2..4]
            Console.Write("Slice numbers.AsSpan(2,3): ");
            Print(slice);

           
        }

        private static void Print(ReadOnlySpan<int> span)
        {
            for (int printCounter = 0; printCounter < span.Length; printCounter++)
            {
                if (printCounter > 0) Console.Write(", ");
                Console.Write(span[printCounter]);
            }
            Console.WriteLine();
        }
    }
}
