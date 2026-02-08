using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo.Entities
{
    public struct WebStatistics
    {
        public int VisitCount;

        // Addition assignment
        public void operator +=(WebStatistics right)
        {
            VisitCount += right.VisitCount;
        }

        // Subtraction assignment
        public void operator -=(WebStatistics right)
        {
            VisitCount -= right.VisitCount;
        }

        // Multiplication assignment
        public void operator *=(WebStatistics right)
        {
            VisitCount *= right.VisitCount;
        }

        // Division assignment
        public void operator /=(WebStatistics right)
        {
            VisitCount /= right.VisitCount;
        }

        // Modulus assignment
        public void operator %=(WebStatistics right)
        {
            VisitCount %= right.VisitCount;
        }

        // Bitwise AND assignment
        public void operator &=(WebStatistics right)
        {
            VisitCount &= right.VisitCount;
        }

        // Bitwise OR assignment
        public void operator |=(WebStatistics right)
        {
            VisitCount |= right.VisitCount;
        }

        // Bitwise XOR assignment
        public void operator ^=(WebStatistics right)
        {
            VisitCount ^= right.VisitCount;
        }

        // Left shift assignment
        public void operator <<=(int shift)
        {
            VisitCount <<= shift;
        }

        // Right shift assignment
        public void operator >>=(int shift)
        {
            VisitCount >>= shift;
        }
    }
}
