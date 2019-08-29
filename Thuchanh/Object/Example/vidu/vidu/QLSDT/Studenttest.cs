using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.QLSDT
{
    public class Studenttest
    { 
        public static StudentMark student = new StudentMark();
        public static int Id = 0;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("Please select option: ");
                Console.WriteLine(" 1. Insert new Student: ");
                Console.WriteLine(" 2. View list of Student: ");
                Console.WriteLine(" 3. Average Mark: ");
                Console.WriteLine(" 4. Exit");
                Console.Write(" Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);
            Process(option);
        }
        public static void Process(int num)
        {
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Insert new Student...");
                        Id += 1;
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list of Student...");
                        student.DisPlay();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average Mark...");
                        //student.AverageStudent();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }

            }
            InitMenu();
        }
        public static void CreateNew()
        {
            student.Id = Id;
            Console.WriteLine("Input FullName: ");
            student.FullName = Console.ReadLine();
            Console.WriteLine("Input ClassName: ");
            student.ClassName = Console.ReadLine();
            Console.WriteLine("Input Semeter: ");
            student.Semester = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Mark");
            for (int i = 0; i < student.SubjectMarkList.Length; i++)
            {
                Console.Write("Input mark {0}: ", i + 1);
                student.SubjectMarkList[i] = Convert.ToInt32(Console.ReadLine());
            }
             student.InsertNew(Id);
        }

    }
    
}
