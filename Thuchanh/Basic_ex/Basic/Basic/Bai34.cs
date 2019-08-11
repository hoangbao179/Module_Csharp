using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai34
    {
        static void Main()
        {
            Console.WriteLine("Input string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Input string check: ");
            string str2 = Console.ReadLine();
            Console.WriteLine(str1.StartsWith(str2));
        }
        
    }
}
