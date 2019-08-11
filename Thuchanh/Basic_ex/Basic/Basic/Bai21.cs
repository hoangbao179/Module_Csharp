using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai21
    {
        static void Main()
        {
            Console.WriteLine("Input number 1: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input number 2: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 == 20 || number2 == 20 || (number1 + number2 == 20));
            Console.ReadKey();
        }
    }
}
