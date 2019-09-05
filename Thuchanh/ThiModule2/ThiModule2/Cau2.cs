using System;
using System.Collections.Generic;
using System.Text;

namespace ThiModule2
{       
    
    public class Cau2
    {
        public static int[] ArrayNumber;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
                int option = 0;
                do
                {
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("1. Tao mang");
                    Console.WriteLine("2. Kiem tra mang tang");
                    Console.WriteLine("3. Sap xep mang");
                    Console.WriteLine("4. Tim kiem mang");
                    Console.WriteLine("5. Thoat");
                    Console.WriteLine("---------------------------");
                    Console.Write("Option: ");

                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        option = number;
                    }

                } while (option > 5 || option <= 0);

                Process(option);

        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Khoi tao mang ");
                        InitArray(ArrayNumber);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Check mang tang ");
                        if (IsInCreaseArray(ArrayNumber))
                        {
                            Console.WriteLine("True");
                        }
                        else
                            Console.WriteLine("False");
                        break;
                    }
                case 3:
                    {
                        SelectedSort(ArrayNumber);
                        break;
                    }
                case 4:
                    {
                        Find(ArrayNumber);
                        break;
                    }

                case 5:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }

            }
            InitMenu();
        }
        //Câu b
        public static void InitArray(int[] ArrayNumber)
        {
            int n;
            do
            {
                Console.Write("Input n: ");
                int.TryParse(Console.ReadLine(), out n); // rào điều kiện nhập không phải số
            }
            while (n <= 0);
            ArrayNumber = new int[n];
            for (int i = 0; i < ArrayNumber.Length; i++)
            {
                var number = 0;
                var temp = false;   // rào điều kiện nhập không phải số
                do
                {
                    Console.WriteLine("Nhap phan tu Array[{0}] ", i);
                    if (int.TryParse(Console.ReadLine(), out number))
                    {
                        ArrayNumber[i] = number;
                        temp = true;
                    }
                }
                while (!temp);
            }
            for (int i = 0; i < ArrayNumber.Length; i++) // hiển thị mảng 
            {
                Console.Write($"{ArrayNumber[i]} ");
            }
        }
        // Câu c
        public static bool IsInCreaseArray(int[] Array)
        {

            for (int i = 0; i < Array.Length - 1 ; i++) // i chỉ được chạy đến length -2 để i+1 là length-1 
            {
                if (Array[i] > Array[i+1])
                {
                    return false;
                }
            }
            return true;
            
        }
        public static void SelectedSort(int[] Array)
        {

            for (int i = 0; i < Array.Length - 1; i++)
            {
                var min = Array[i];
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < min)
                    {
                        min = Array[j];
                        var temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = temp;
                    }
                }

            }
            Console.WriteLine(string.Join(",", Array));

        }
        public static void Find(int[] Array)
        {
            if (IsInCreaseArray(Array)) //mảng đã săp xếp chưa
            {
                Console.WriteLine("Input number");
                int num = 0;
                do
                {
                    Console.Write("Input n: ");
                    int.TryParse(Console.ReadLine(), out num); // rào điều kiện nhập không phải số
                }
                while (num <= 0);
                NhiPhan(Array, num); // sắp xếp mảng 


            }
            else Console.WriteLine("Mảng chưa sắp xếp không được sử dụng chức năng này");
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
