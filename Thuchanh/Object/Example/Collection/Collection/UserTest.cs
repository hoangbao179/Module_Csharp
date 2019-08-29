using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    public class UserTest
    {
        public static Dictionary<int, User> UserList = new Dictionary<int, User>();
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
                Console.WriteLine("USER MANAGEMENT SYSTEM");
                Console.WriteLine("Please select an option from 1 to 4");
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Check user");
                Console.WriteLine("3. Display all users");
                Console.WriteLine("4. Exit");

                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);

            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        CreateUser();
                        break;
                    }
                case 2:
                    {
                        CheckUser();
                        break;
                    }
                case 3:
                    {
                       DisPlay();
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

        public static void CreateUser()
        {
            var user = new User();
            Id = Id + 1;
            user.Id = Id;
            Console.Write("Please input user name: ");
            user.Name = Console.ReadLine();

            Console.Write("Please input passsword: ");
            user.PassWord = Console.ReadLine();
            Console.WriteLine("Do you want to add number (Y/N)");
            var addPhone = Console.ReadLine();
            int phonenumber;
            while (addPhone == "y" || addPhone == "Y")
            {
                Console.Write("Please input phone number:");
                phonenumber = Convert.ToInt32(Console.ReadLine());
                user.phoneList.Add(phonenumber);
                Console.WriteLine("Do you want to add number (Y/N)");
                addPhone = Console.ReadLine();
            }
            UserList.Add(user.Id, user);

        }
        public static void CheckUser()
        {
            Console.Write("Input Name: ");
            string nameUser = Console.ReadLine();
            Console.Write("Input Password: ");
            string passUser = Console.ReadLine();
            bool checker = false;
            foreach (var item in UserList)
            {
                if(item.Value.Name == nameUser && item.Value.PassWord == passUser)
                {
                    checker = true;
                    break;
                }
            }

            if (checker)
            {
                Console.WriteLine("User checker ");
            }
            else
            {
                Console.WriteLine("User not found ");
            }
        }
        public static void DisPlay()
        {
            foreach (var item in UserList)
            {
                Console.WriteLine(item.Value.Info());
            }
        }
    }
}
