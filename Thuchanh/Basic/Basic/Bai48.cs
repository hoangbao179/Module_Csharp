using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai48
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 22, 3, 3, 2, 2, 6, 7, 8, 5, 3, 4, 5, 6, 7, 1 };
            Console.WriteLine(arrayNumber[0] == arrayNumber[arrayNumber.Length - 1]);
            Console.ReadKey();
        }
    }
}
