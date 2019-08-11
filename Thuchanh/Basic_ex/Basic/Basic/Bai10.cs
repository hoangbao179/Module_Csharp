using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai10
    {
        static void Main(string[] arg)
        {
            int num1, num2, num3;
            Console.WriteLine("Input num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input num2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input num3: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Result of specified numbers {0}, {1} and {2},({0}+{1}).{2} is {3} and {0}.{1}+{1}.{2} is {4}", num1, num2, num3, (num1 + num2) * num3, num1*num2 + num2*num3);
            Console.ReadLine();

        }
    }
}
