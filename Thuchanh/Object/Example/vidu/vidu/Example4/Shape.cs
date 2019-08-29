using System;
using System.Collections.Generic;
using System.Text;
using vidu.Example4.Models;

namespace vidu.Example4
{
    class Shape
    {
        protected Locations c = new Locations();
        public void setLocation( double side1, double side2)
        {
            c.X = side1;
            c.Y = side2;
        }
        public double Area()
        {
            return c.X * c.Y;
        }
        public double Primeter()
        {
            return 2 * (c.X + c.Y);
        }
    }
}
