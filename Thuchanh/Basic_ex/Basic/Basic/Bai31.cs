using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai31
    {
        static void Main()
        {
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1, 4, -5, -2 };
            int[] array3 = new int[array1.Length];
            for( int i = 0; i< array1.Length; i++)
            {
                array3[i]=(array1[i] * array2[i]);
            }
            for (int i = 0; i < array3.Length; i++) { 
            Console.Write(array3[i] + " ");
            
            }
            Console.ReadLine();
        }
    }
}
