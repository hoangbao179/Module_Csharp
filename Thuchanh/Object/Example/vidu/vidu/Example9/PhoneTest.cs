using System;
using vidu.Example9.Models;

namespace vidu.Example9
{
    public class PhoneTest
    {
        public static PhoneBook phoneBook = new PhoneBook();
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
                Console.WriteLine("PHONEBOOK MANAGEMENT SYSTEM");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. DisPlay");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please seclcet an opton from 1 to 7");
                Console.WriteLine("---------------------------");
                Console.Write("Option: ");

                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }

            } while (option > 7 || option <= 0);

            Process(option);
        }

        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert Phone ......");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();
                        Console.Write( "Input number phone: ");
                        var phone = Console.ReadLine();
                        phoneBook.InsertPhone(name, phone);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Remove Phone ......");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();
                        phoneBook.RemovePhone(name);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Update Phone....");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();
                        Console.Write("Input number phone: ");
                        var phone = Console.ReadLine();
                        phoneBook.UpdatePhone(name, phone);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Search Phone");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();
                        phoneBook.SearchPhone(name);
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Sort");
                        phoneBook.Sort();
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("ViewList");
                        DisPlay();
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Exit");
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }

            }
            InitMenu();
        }

        public static void DisPlay()
        {
            Console.WriteLine("Name\t\t\tPhonenumber");
            if (phoneBook.PhoneList != null && phoneBook.PhoneList.Count > 0)
            {
                foreach (PhoneItem phoneItem in phoneBook.PhoneList)
                {
                    Console.WriteLine("{0}\t\t\t{1}",phoneItem.Name,phoneItem.PhoneNumber);
                }
            }
        }
    }
}
