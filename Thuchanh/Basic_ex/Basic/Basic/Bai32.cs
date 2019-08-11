using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai32
    {
        static void Main()
        {
            Console.WriteLine("Input string");
            string str = Console.ReadLine();
            if(str.Length < 4)
            {
                Console.WriteLine(str);
            }
            else
            {
                string string1 = str.Substring(str.Length - 4, 4);
                Console.WriteLine(string1 + string1 + string1 + string1);
                Console.ReadKey();
               
            }


        }
    }
}
