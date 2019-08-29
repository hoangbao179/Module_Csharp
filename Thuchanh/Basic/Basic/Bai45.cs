using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai45
    {
        static void Main()
        {
            int[] arrayNumber = { 1, 2, 3, 3, 2, 2, 6, 7, 8, 5, 3, 4, 5, 6, 7, 9 };
            Console.WriteLine("Input number");
            int number = Convert.ToInt32(Console.ReadLine());
            int dem = 0;
            for(int i =0; i<arrayNumber.Length; i++)
            {
                if (arrayNumber[i] == number)
                {
                    dem = dem + 1;
                }
            }
            if (dem > 0) Console.WriteLine("Number {0} hien thi {1} lan", number, dem);
            else Console.WriteLine("Number {0} khong ton tai trong mang", number);
            Console.ReadKey();
        }
    }
}
