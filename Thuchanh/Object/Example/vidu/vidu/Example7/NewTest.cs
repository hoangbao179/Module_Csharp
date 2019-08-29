using System;

namespace vidu.Example7
{
    public class NewTest
    {
        public static News news = new News();
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
                Console.WriteLine("Management News");
                Console.WriteLine("1.Insert news");
                Console.WriteLine("2.View list news");
                Console.WriteLine("3.Average rate");
                Console.WriteLine("4.Exit");
                Console.WriteLine("Please seclcet an opton from 1 to 4");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }

            } while (option > 4 || option <= 0);

            Process(option);
        }

        public static void Process(int selected)
        {
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert new ......");
                        Id +=1;
                        CreateNews();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("View list ......");
                        news.DisPlay();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Average rate....");
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
        public static void CreateNews()
        {
            news.Id = Id;
            Console.Write("Input title:");
            news.Title = Console.ReadLine();
            Console.Write("Input publish date:");
            news.PublisDate = Console.ReadLine();
            Console.Write("Input author: ");
            news.Author = Console.ReadLine();
            Console.Write("Input content: ");
            news.Content = Console.ReadLine();
            Console.Write("Input rate:");
            for (int i = 0; i < news.RateList.Length; i++)
            {
                Console.Write("Input rate {0} ", i + 1);
                news.RateList[i] = int.Parse(Console.ReadLine());
            }

            news.InsertNew(Id);
        }

    }
}
