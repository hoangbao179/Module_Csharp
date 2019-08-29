using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Book
{
    public class Booktest
    {
        public static Book book = new Book();
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
                Console.WriteLine("1. Insert new book ");
                Console.WriteLine("2. View list of books ");
                Console.WriteLine("3. Average Price ");
                Console.WriteLine("4. Exit");
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
                        Console.WriteLine("Insert new Book...");
                        Id += 1;
                        CreateNew();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list of books...");
                        book.DisPlay();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average Mark...");
                       
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
            book.Id = Id;
            Console.WriteLine("Input Name");
            book.Name = Console.ReadLine();
            Console.WriteLine("Input PublishDate");
            book.PublishDate = Console.ReadLine();
            Console.WriteLine("Input Author: ");
            book.Author = Console.ReadLine();
            Console.WriteLine("Input Language :");
            book.Language = Console.ReadLine();
            for (int i = 0; i < book.PriceList.Length; i++)
            {   
                Console.WriteLine("Input Price {0}: ", i+1);
                book.PriceList[i] = Convert.ToInt32(Console.ReadLine());

            }
            book.InsertNew(Id);
            
        }
    }

}
