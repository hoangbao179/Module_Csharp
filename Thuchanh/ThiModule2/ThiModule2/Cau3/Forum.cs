using System;
using System.Collections.Generic;
using System.Text;

namespace ThiModule2.Cau3
{
    public class Forum
    {
        public static Post post = new Post();
        public static int Id = 0;
        public static void Main()
        {
            Menu();
        }
        public static void Menu()
        {
            int option = 0;
            do
            {

                Console.WriteLine("1. Create post");
                Console.WriteLine("2. Calculator");
                Console.WriteLine("3. Showlist");
                Console.WriteLine("4. Exit");
                Console.Write("Select: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option < 0);
            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert post ......");
                        Id += 1;
                        CreatePost();
                        break;
                    }
                case 2:
                    {

                        break;
                    }
                case 3:
                    {

                        break;
                    }
                case 4:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
        }
        public static void CreatePost()
        {
            post.Id = Id;
            Console.Write("Input title:");
            post.Title = Console.ReadLine();
            Console.Write("Input author: ");
            post.Author = Console.ReadLine();
            Console.Write("Input content: ");
            post.Content = Console.ReadLine();
            Console.Write("Input rate:");
            for (int i = 0; i < post.Rates.Length; i++)
            {
                Console.Write("Input rate {0} ", i + 1);
                post.Rates[i] = int.Parse(Console.ReadLine());
            }

            post.InsertPost(Id);
        }
    }
}
