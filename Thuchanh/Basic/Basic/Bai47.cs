using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai47
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 22, 3, 3, 2, 2, 6, 7, 8, 5, 3, 4, 5, 6, 7, 9 };
            int sum = 0;
            for ( int i = 0; i<arrayNumber.Length; i++)
            {
                sum = sum + arrayNumber[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
