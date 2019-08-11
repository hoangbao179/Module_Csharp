using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bai5
    {
        static void Main(string[] arg)
        {
            int num1, num2, temp;
            Console.Write("\n Input number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\n Input numbr 2: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("Apter swap ");
            Console.WriteLine("1st Number: " + num1);
            Console.WriteLine("2nd Number: " + num2);
            Console.ReadLine();

        }
    }
}
