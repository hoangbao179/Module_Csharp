using System;
using System.Collections.Generic;
using System.Text;
using vidu.Example3.Model;

namespace vidu.Example3
{
    class Shape
    {
        private Location c = new Location();

       // public Location C { get => c; set => c = value; }

        //public string tostring1()
        //{

        //}
        public void setLocation(double side1, double side2)
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
