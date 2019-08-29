using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example3
{
    class Rectangle : Shape
    {
        protected double side1;
        protected double side2;
        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }

        public void Side(double side1, double side2)
        {
            setLocation(side1, side2);
        }
    }
}
