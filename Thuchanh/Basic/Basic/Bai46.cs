using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai46
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 22, 3, 3, 2, 2, 6, 7, 8, 5, 3, 4, 5, 6, 7, 9 };
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arrayNumber[0] == number || arrayNumber[arrayNumber.Length - 1] == number);
            Console.ReadKey();
        }
    }
}
