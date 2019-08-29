using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai57
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 1, 1, 4, 5, 8, 9, 55, 1, 4, 4, 5, 884, 4, 5 };
            int max = 0;
            for( int i = 0; i<arrayNumber.Length-1; i++)
            {
                if((arrayNumber[i]*arrayNumber[i+1]) > max)
                {
                    max = (arrayNumber[i] * arrayNumber[i + 1]);
                }
            }
            Console.WriteLine(max);
        }
    }
}
