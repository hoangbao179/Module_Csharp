using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai39
    {
        static void Main()
        {
            Console.WriteLine("Input num1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input num2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input num3:");
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max " + Math.Max(number1, Math.Max(number2, number3)));
            Console.WriteLine("Min " + Math.Min(number1, Math.Min(number2, number3)));
        }
       
    }
}
