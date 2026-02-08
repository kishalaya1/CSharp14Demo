using CSharp14Demo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo
{
    public class UserDefinedCompundAssignmentExample
    {
        public static void Demo()
        {

            // Addition assignment (+=)
            var stats1 = new WebStatistics { VisitCount = 100 };
            var stats2 = new WebStatistics { VisitCount = 50 };
            stats1 += stats2;            
            Console.WriteLine($"Addition (100 += 50): {stats1.VisitCount}");  // 150

            // Subtraction assignment (-=)
            stats1 = new WebStatistics { VisitCount = 100 };
            stats2 = new WebStatistics { VisitCount = 30 };
            stats1 -= stats2;
            Console.WriteLine($"Subtraction (100 -= 30): {stats1.VisitCount}");  // 70

            // Multiplication assignment (*=)
            stats1 = new WebStatistics { VisitCount = 10 };
            stats2 = new WebStatistics { VisitCount = 5 };
            stats1 *= stats2;
            Console.WriteLine($"Multiplication (10 *= 5): {stats1.VisitCount}");  // 50

            // Division assignment (/=)
            stats1 = new WebStatistics { VisitCount = 100 };
            stats2 = new WebStatistics { VisitCount = 4 };
            stats1 /= stats2;
            Console.WriteLine($"Division (100 /= 4): {stats1.VisitCount}");  // 25

            // Modulus assignment (%=)
            stats1 = new WebStatistics { VisitCount = 100 };
            stats2 = new WebStatistics { VisitCount = 30 };
            stats1 %= stats2;
            Console.WriteLine($"Modulus (100 %= 30): {stats1.VisitCount}");  // 10

            // Bitwise AND assignment (&=)
            stats1 = new WebStatistics { VisitCount = 0b1111 };  // 15 in binary
            stats2 = new WebStatistics { VisitCount = 0b1010 };  // 10 in binary
            stats1 &= stats2;
            Console.WriteLine($"Bitwise AND (15 &= 10): {stats1.VisitCount}");  // 10 (0b1010)

            // Bitwise OR assignment (|=)
            stats1 = new WebStatistics { VisitCount = 0b1100 };  // 12 in binary
            stats2 = new WebStatistics { VisitCount = 0b1010 };  // 10 in binary
            stats1 |= stats2;
            Console.WriteLine($"Bitwise OR (12 |= 10): {stats1.VisitCount}");  // 14 (0b1110)

            // Bitwise XOR assignment (^=)
            stats1 = new WebStatistics { VisitCount = 0b1100 };  // 12 in binary
            stats2 = new WebStatistics { VisitCount = 0b1010 };  // 10 in binary
            stats1 ^= stats2;
            Console.WriteLine($"Bitwise XOR (12 ^= 10): {stats1.VisitCount}");  // 6 (0b0110)

            // Left shift assignment (<<=)
            stats1 = new WebStatistics { VisitCount = 5 };
            stats1 <<= 2;  // Shift left by 2 positions
            Console.WriteLine($"Left Shift (5 <<= 2): {stats1.VisitCount}");  // 20

            // Right shift assignment (>>=)
            stats1 = new WebStatistics { VisitCount = 20 };
            stats1 >>= 2;  // Shift right by 2 positions
            Console.WriteLine($"Right Shift (20 >>= 2): {stats1.VisitCount}");  // 5

        }
        public static void MovieDemo() {
            var movie = new Movie("Interstellar", "Christopher Nolan", 2014, 8);
            movie += 2;  // Rating becomes 10
        }
        public static void Vector2Demo() {
            Vector2 a = new Vector2 { X = 1, Y = 2 };
            Vector2 b = new Vector2 { X = 3, Y = 4 };

           // Uses the + operator
            a += b;
            Console.WriteLine($"Value of a.X  : { a.X} Value of a.Y : { a.Y}");
        }
    }
}

