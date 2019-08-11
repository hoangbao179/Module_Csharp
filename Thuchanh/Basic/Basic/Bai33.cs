using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai33
    {
        static void Main()
        {
            Console.WriteLine("input number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(check(number));
            Console.ReadKey();
        }
        static bool check(int number)
        {
            if (number % 3 == 0 || number % 7 == 0)
            {
                return true;
            }
            else return false;
        }
    }
}
