using System;
using System.IO;

namespace ReadFile_WriteFile.BaiTap1
{
    public class InputOutput
    {
        public static void Main()
        {
            Console.WriteLine("Input so luong phan tu");
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] ArrayNumber = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine("Nhap phan tu thu {0}", i + 1);
                ArrayNumber[i] = Convert.ToInt32(Console.ReadLine());
            }
            WriteArray(amount, ArrayNumber);
            ReadAndWrite();
        }

        public static void WriteArray(int amount, int[] ArrayNumber)
        {
            FileStream file = new FileStream($"E:\\Học hành\\Codegym\\Module_Csharp\\Filelog\\Vidulog\\Input.txt", FileMode.Create);
            using (StreamWriter write = new StreamWriter(file))
            {
                write.WriteLine(amount);
                write.WriteLine("{0}", string.Join(" ", ArrayNumber));
            }
            file.Close();
        }

        public static void ReadAndWrite()
        {
            int sumNumber = 0;
            string[] ArrayNum = null;
            FileStream file = new FileStream($"E:\\Học hành\\Codegym\\Module_Csharp\\Filelog\\Vidulog\\Input.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                int index = 0;
                
                while ((line = reader.ReadLine()) != null) // hàng trống 
                {
                    if (index == 0) 
                    {
                        index++;
                        continue;   //bỏ qua hàng đầu tiên
                    }
                    ArrayNum = line.Split(" ");
                    int sum = 0;
                    for (int i = 0; i < ArrayNum.Length; i++)
                    {
                        sum += Convert.ToInt32(ArrayNum[i]);
                    }
                    
                    sumNumber = sum;
                }
                file.Close();
            }

            FileStream fileArray = new FileStream($"E:\\Học hành\\Codegym\\Module_Csharp\\Filelog\\Vidulog\\Output.txt", FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fileArray))
            {
                writer.WriteLine("Tổng giá trị là : {0}", sumNumber);
                writer.Write("Các số chẵn: ");
                for (int i = 0; i < ArrayNum.Length; i++)
                {
                    if((Convert.ToInt32(ArrayNum[i])) %2 == 0)
                    {
                        writer.Write($" {Convert.ToInt32(ArrayNum[i])}");
                    }
                }
                writer.WriteLine();// xuống dòng
                int[] Number = new int[ArrayNum.Length];
                for (int i = 0; i < ArrayNum.Length; i++)
                {
                    Number[i] = Convert.ToInt32(ArrayNum[i]);
                }
                writer.WriteLine($" Dãy số: {InsertSort(Number)}");

            }

        }

        public static string InsertSort(int[] A) // sắp xếp 
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
            return string.Join(" ", A);
        }
    }
}
