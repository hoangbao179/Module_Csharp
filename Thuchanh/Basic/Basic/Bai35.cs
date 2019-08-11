using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai35
    {
        static void Main()
        {
            Console.WriteLine("input number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(check(number1, number2));
        }

        static bool check (int number1, int number2)
        {
            if (number1 < 100 && number2 > 200 || number1 > 200 && number2 < 100)
            {
                return true;
            }
            else return false;
        }
    }
}
