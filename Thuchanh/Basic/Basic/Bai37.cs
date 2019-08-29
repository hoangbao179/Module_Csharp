using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai37
    {
        static void Main()
        {
            Console.WriteLine("Input String : ");
            string str = Console.ReadLine();
            string str1 = str.Substring(1, 2);
            Console.WriteLine(str1 == "HP");
            if (str1 == "HP")
            {
                Console.WriteLine((str.Substring(0, 1)) + (str.Substring(3, str.Length - 3)));
            }
            else Console.WriteLine(str);
            Console.ReadKey();
        }
      
    }
}
