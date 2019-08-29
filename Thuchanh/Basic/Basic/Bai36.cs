using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai36
    {
        static void Main()
        {
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(check(number));
            Console.ReadKey();
        }
        static bool check(int number)
        {
            if (number > (-10) && number < 10)
            {
                return true;
            }
            else return false;
        }
    }
}
