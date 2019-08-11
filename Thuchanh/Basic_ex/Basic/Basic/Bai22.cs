using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai22
    {
        static void Main()
        {
            Console.WriteLine("Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(abss(number));
            Console.ReadKey();
        }
            static bool abss(int number)
        {
            if (Math.Abs(number - 100) < 20 || Math.Abs(number - 200) < 20)
            {
                return true;
            }
            else return false;
        }
    }
}
