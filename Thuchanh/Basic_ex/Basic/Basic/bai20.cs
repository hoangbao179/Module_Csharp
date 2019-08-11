using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class BAi20
    {
        static void Main()
        {
            Console.WriteLine("Input number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(result(number1, number2));
            Console.ReadKey();
        }
            static int result(int number1, int number2)
            {
            if (number1 > number2)
            {
                return (2 * (number1 - number2));
            }
            else return (Math.Abs(number1 - number2));
        }

            

    }
}

