using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai42
    {
        static void Main()
        {
            Console.WriteLine("Input String : ");
            string str = Console.ReadLine();
            if (str.Length < 4)
            {
                Console.WriteLine(str.ToUpper());
            }
            else
            {   
                Console.WriteLine((str.Substring(0, 3)).ToLower() + str.Substring(3, str.Length - 3));
            }
            Console.ReadKey();
        }
    }
}
