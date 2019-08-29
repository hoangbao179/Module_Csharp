using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai51
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 7 };
            Console.WriteLine(Math.Max(arrayNumber[0], arrayNumber[arrayNumber.Length - 1]));
            Console.ReadKey();
        }
    }
}
