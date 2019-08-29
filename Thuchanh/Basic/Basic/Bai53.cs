using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai53
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 7 };
            int amout = 0;
            foreach(int i in arrayNumber)
            {
                if(i%2 == 1)
                {
                    amout = amout + 1;
                }
            }
            if (amout > 0) Console.WriteLine("Array odd");
            else Console.WriteLine("Array not add");
            Console.ReadKey();
        }
    }
}
