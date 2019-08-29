using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example3
{
    class test
    {
        static void Main()
        {
            var rect = new Rectangle();
            rect.Side1 = 15.5;
            rect.Side2 = 15.63;
            //rect.Side();
            Console.WriteLine(rect.Area());
            Console.WriteLine(rect.Primeter());

        }
    }
}
