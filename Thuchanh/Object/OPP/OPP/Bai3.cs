using System;
using System.Collections.Generic;
using System.Text;

namespace OPP
{
    class Bai3
    {
        public class Shape
        {
            protected float x, y;
            protected float X {
                get { return x; }
                set { x = X; }

            }
            protected float Y {
                get { return y; }
                set { y = Y; }
            }
            public double Area()
            {
                return X * Y;
            }
            public double Perimeter()
            {
                return 2 * (X + Y);
            }

        }
        public class Rectangle : Shape
        {
            public Rectangle(side1, side2)
            {
                X = side1;
                Y = side2;
            }
        }
    }
}
