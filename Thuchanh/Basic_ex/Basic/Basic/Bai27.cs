using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai27
    {
        static int sumNumber(int number)
        {
            int sum = 0, n;
            while (number > 0)
            {
                n = number % 10;
                sum = sum + n;
                number = (number - n) / 10; 
            }
            return sum;
        }

        static void Main()
        {
            Console.WriteLine("input number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sumNumber(number));
        }
    }
}
