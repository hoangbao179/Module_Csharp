using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example8
{
    class TestNew
    {
        public static News news = new News();
        public static void Main()
        {
            Menu();
        }

        public static void Menu()
        {
            int option = 0;
            do
            {

                Console.WriteLine("1. Insert news");
                Console.WriteLine("2. View list news");
                Console.WriteLine("3. Average rate");
                Console.WriteLine("4. Exit");
                Console.Write("Select: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option < 0);

    {

            }
        }
    }
}
