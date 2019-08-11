using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai18
    {
        static void Main()
        {
            Console.WriteLine("Input number 1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2:");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 > 0 && number2 < 0 || number1 < 0 && number2 > 0);
            Console.ReadKey();
        }
    }
}
