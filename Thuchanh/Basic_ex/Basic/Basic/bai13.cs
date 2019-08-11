using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bai13
    {
        static void Main()
        {
            int number;
            Console.WriteLine("Input number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0} {0}", number);
            Console.WriteLine("{0}{0}{0}", number);
            Console.ReadKey();
        }
    }
}
