using System;
using System.Collections.Generic;
using System.Text;

namespace ThiModule2
{
    public class Bai1
    {
        public static void Main()
        {
            InitMaxtrix();
        }

        // Câu a
        public static void InitMaxtrix()
        {

            int n, m;
            do
            {
                Console.Write("Input n: "); 
                int.TryParse(Console.ReadLine(), out n); // rào điều kiện nhập không phải số
            }
            while (n <= 0);
            do
            {
                Console.Write("Input m: ");
                int.TryParse(Console.ReadLine(), out m); // rào điều kiện nhập không phải số
            }
            while (m <= 0);
            int[,] ArrayNumber = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    var number = 0;
                    var temp = false;   // rào điều kiện nhập không phải số
                    do
                    {
                        Console.WriteLine("Nhap phan tu Array[{0}][{1}] ", i, j);
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            ArrayNumber[i, j] = number;
                            temp = true;
                        }
                    }
                    while (!temp);
                }
            }
            for (int i = 0; i < n; i++) // hiển thị mảng 
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{ArrayNumber[i,j]} ");
                }
                Console.WriteLine();
            }
        }
        // Câu b
        public static int Sum( int[] Array)
        {
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                sum += Array[i];
            }
            return sum;
        }
        
        //Câu 3
        //public static void ShowMaxRow(int[,] ArrayNumber)
        //{
        //    //int sumArray = 0;
        //    int[] SumMax = new int[ArrayNumber.GetLength(1)]; // Tạo mảng có chiều dài bằng số dòng ném các tổng vào mảng
        //    for (int i = 0; i < ArrayNumber.GetLength(0); i++) // duyệt từng dòng
        //    {
        //        //Sum()
        //    }
        //}
    }
}
