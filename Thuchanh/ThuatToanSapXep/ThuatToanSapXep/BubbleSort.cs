using System;
using System.Collections.Generic;
using System.Text;

namespace ThuatToanSapXep
{
    public class BubbleSort
    {
        public static void Main()
        {
            int[] ArrayNumber = new int[8] { 7, 9, 5, 4, 7, 1, 5, 9 };
            Console.WriteLine("Array: {0}",string.Join(",",ArrayNumber));
            Bubble_Sort(ArrayNumber);
            Console.WriteLine("Array: {0}", string.Join(",", ArrayNumber));

        }
        public static void Bubble_Sort(int[] A)
        {
            for (int j = 0; j < A.Length; j++)
            {

                for (int i = 0; i < A.Length - 1; i++)
                {
                    if (A[i] > A[i + 1])
                    { 
                        Swap(ref A[i], ref A[i + 1]);
                    }
                }
            }
        }
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}
