using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai52
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 5 };
            int[] arr2 = {0, 3, 8};
            int[] arr3 = { -1, 0, 2 };
            int[] arr4 = { arr1[1], arr2[1], arr3[1] };
            Console.WriteLine("[{0}]", string.Join(",", arr4));
            Console.ReadKey();


        }
    }
}
