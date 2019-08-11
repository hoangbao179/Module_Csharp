using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bai6
    {
        static void Main(string[] arg)
        {
            int num1, num2, num3;
            Console.WriteLine("Input number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 3: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Multi " + num1 * num2 * num3);
            Console.ReadLine();
        }
    }
}
