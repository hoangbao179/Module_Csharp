using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai40
    {
        static void Main()
        {
            Console.WriteLine("Input number1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input number2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 == number2)
            {
                Console.WriteLine("0");
            }
            else if (Math.Abs(number1 - 20) > Math.Abs(number2 - 20))
            {
                Console.WriteLine(number2);
            }
            else Console.WriteLine(number1);
            Console.ReadKey();
        }
    }
}
