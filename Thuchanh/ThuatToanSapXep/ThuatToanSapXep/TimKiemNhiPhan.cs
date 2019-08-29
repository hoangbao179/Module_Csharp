using System;

namespace ThuatToanSapXep
{
    public class TimKiemNhiPhan
    {
        public static void Main()
        {
            int[] ArrayNumber = new int[10] { 1, 8, 9, 5, 7, 1, 1, 44, 2, 56 };
            Console.WriteLine("Array: {0}", string.Join(",", ArrayNumber));
            Sapxep(ArrayNumber);
            Console.WriteLine("Array da sap xep: {0}", string.Join(",", ArrayNumber));
            Console.Write("Input so can tim ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("index: {0}", string.Join(",", NhiPhan(ArrayNumber, number)));


        }
        public static void Sapxep(int[] A)
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
        public static int NhiPhan(int[] A, int num)
        {
            int min = 0;
            int max = A.Length - 1;
            int mid = 0;

            while (min <= max)
            {
                mid = (max + min) / 2;
                if (A[mid] == num)
                {
                    return mid;
                }
                else if (A[mid] < num)
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return -1;
        }
    }
}
