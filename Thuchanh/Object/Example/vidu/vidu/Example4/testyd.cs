using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example4
{
    class testyd
    {
        public static void Main()
        {
            var rect = new Rectangle();
            rect.Side(15, 4);
            Console.WriteLine(rect.Area());
            Console.WriteLine(rect.Primeter());
        }
    }
}
