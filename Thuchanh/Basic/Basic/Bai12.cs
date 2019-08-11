using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai12
    {
        static void Main(string[] arg)
        {
            int number;
            Console.WriteLine("Input number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} {0} {0} {0} ", number);
            Console.WriteLine("{0}{0}{0}{0}", number);
            Console.WriteLine(number + " " + number + " " + number + " " + number);
            Console.WriteLine(number + "" + number + "" + number + "" + number);
            Console.ReadLine();

        }
    }
}
