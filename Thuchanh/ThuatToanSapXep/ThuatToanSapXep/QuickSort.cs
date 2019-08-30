using System;

namespace ThuatToanSapXep
{
    public class QuickSort
    {
        public static void Main()
        {
            int[] ArrayNumber = new int[10] { 1, 2, 4, 7, 1, -6, 1, 7, 0, 55 };
            Console.WriteLine("Mang chua sap xep: {0}", string.Join(",", ArrayNumber));
            SapXepNhanh(ArrayNumber, 0, ArrayNumber.Length - 1);
            Console.WriteLine("Mang da sap xep: {0}", string.Join(",", ArrayNumber));

        }
        public static void SapXepNhanh(int[] A, int left, int right)
        {
            int mid = (left + right) / 2;
            int i = left;
            int j = right;
            do
            {
                while (A[i] < A[mid])
                {
                    i++;
                }
                while (A[mid] < A[j])
                {
                    j--;
                }
                if (i <= j)
                {
                    Swap(ref A[i], ref A[j]);
                    i++;
                    j--;
                }
            }
            while (i < j);
            if (left < j)
            {
                SapXepNhanh(A, left, j);
            }
            if (i < right)
            {
                SapXepNhanh(A, i, right);
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
