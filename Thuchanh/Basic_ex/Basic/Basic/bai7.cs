using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bai7
    {
        static void Main(string[] arg)
        {
            int num1, num2;
            Console.WriteLine("Input number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
            Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
            Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
            Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
            Console.ReadLine();
        }
    }
}
