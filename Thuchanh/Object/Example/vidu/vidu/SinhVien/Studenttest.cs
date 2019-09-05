using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.SinhVien
{
    public class Studenttest
    {
        public static Student student = new Student();
        public static void Main()
        {
            
        }
        public static void InitMenu()
          {
            int option = 0;
            do
            {

                Console.WriteLine("---------------------------");
                Console.WriteLine("1. Insert new Student");
                Console.WriteLine("2. View list of Students");
                Console.WriteLine("3. Search Students");
                Console.WriteLine("Exit");
                Console.WriteLine("---------------------------");
                Console.Write("Option");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option <= 1 || option >= 4);
            Process(option);
        }
        public static void Process(int option)
        {
            int Id = 0;
            switch (option)
            {
                case 1:
                    {
                        Console.Write("Input FullName");
                        student.FullName = Console.ReadLine();
                        Console.Write("Input Date Of Birth");
                        student.DateOfBirth = Console.ReadLine();
                        Console.Write("Input native");
                        student.Native = Console.ReadLine();
                        Console.Write(" Input ClassRoom");
                        student.ClassRoom = Console.ReadLine();
                        Console.Write("Input PhoneNo");
                        student.PhoneNo = Console.ReadLine();
                        Console.Write("Input Mobile");
                        student.Mobile =Convert.ToInt32(Console.ReadLine());
                        break;
                    }
             
            }
        }
    }
}
