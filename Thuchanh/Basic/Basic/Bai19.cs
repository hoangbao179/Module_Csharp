using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai19
    {
        static void Main()
        {
            Console.WriteLine("Input number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            if (number1 == number2)
                {
                    Console.WriteLine(number1 * 3);
                }
            else Console.WriteLine(number1 + number2);
            Console.ReadKey();

        }
    }
}
