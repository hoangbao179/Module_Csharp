using System;

namespace ThuatToanSapXep
{
    public class SapXepChen
    {
        public static void Main()
        {
            int[] Array = new int[10]; // tạo mảng 10 phần tử mặc định giá trị 0;
            Console.WriteLine(string.Join(",", Array)); // in mảng
            int i = 0;
            Console.WriteLine("Do you want to add number (Y/N)");
            var check = Console.ReadLine();

            while (check == "y" || check == "Y")
            {
                i++;
                Console.Write("Input array index {0}: ",i);
                Array[i] = Convert.ToInt32(Console.ReadLine());
                InsertSort(Array);
                Console.WriteLine("-------------------------");
                Console.WriteLine(string.Join(",", Array));
                Console.WriteLine("Do you want to add number (Y/N)");
                check = Console.ReadLine();

            }
            Console.WriteLine(string.Join(",", Array));
            Console.ReadKey();
        }
        public static void InsertSort(int[] A)
        {
            int temp;
            int index;
            for (int i = 1; i < A.Length; i++)
            {
                temp = A[i];
                index = i - 1;
                while (index >= 0 && A[index] > temp)
                {
                    A[index + 1] = A[index--];
                }
                A[index + 1] = temp;
            }
        }
    }
}
