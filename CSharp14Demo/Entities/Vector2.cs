using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp14Demo.Entities
{
    public struct Vector2
    {
        public double X, Y;

        public void operator +=(Vector2 right)
        {
            X += right.X;
            Y += right.Y;
        }
    }

}
