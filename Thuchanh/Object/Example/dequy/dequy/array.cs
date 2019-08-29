using System;
using System.Collections.Generic;
using System.Text;

namespace dequy
{
    public class array
    {
        public static void Main()
        {
            int[] A = { 1, 2, 3, 4, 4, 2, 1, 4, 4, 1, 3, 1, 1 };
            //Console.WriteLine(Sumarray(A, A.Length));
            Console.WriteLine(string.Join(",",A));
            Console.WriteLine("----------------------------");
            SelectionSort(ref A);
            Console.WriteLine(string.Join(",", A));
            //Console.WriteLine();
        }
        //public static long Sumarray(int[] A, int Lengtharray)
        //{
        //    if(Lengtharray == 0)
        //    {
        //        return 0;
        //    }
        //    return Sumarray(A, Lengtharray - 1) + A[Lengtharray - 1];
        //}
        public static void SelectionSort(ref int[] A)
        {
            for (int i = 0; i < A.Length-1; i++)
            {
                var min = A[i];
                var pos = i;
                for (int j = i+1; j < A.Length; j++)
                {
                    if (A[j] < min)
                    {
                        min = A[j];
                        pos = j;
                    }
                }
                var temp = A[i];
                A[i]= A[pos];
                A[pos] = temp;
            }

        }
    }
}
