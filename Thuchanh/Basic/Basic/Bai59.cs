using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai59
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 2, 9, 8, 9 };
            Console.WriteLine(check(arrayNumber));
        }

        static bool check(int[] arrayNumber)
        {
            int amout = 0;
            for (int i = 0; i<arrayNumber.Length-1; i++) {
                if (arrayNumber[i] < arrayNumber[i + 1])
                {
                    amout = amout + 1;
                }
            }
            if (amout == arrayNumber.Length - 1)
            {
                return true;
            }
            else return false;
        }
    }   

}
