using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class max
    {
        static void Main()
        {
            int[] arr2 = { 1, 5, 9, 4, 23, 8, 5, 6, 5, 5, 79 };
            for (int i =0; i<arr2.Length/2; i++)
            {
                var temp = arr2[i];
                arr2[i] = arr2[arr2.Length - 1 - i];
                arr2[arr2.Length - 1 - i] = temp;
            }
            Console.WriteLine(String.Join(",", arr2));
        }
    }
}
