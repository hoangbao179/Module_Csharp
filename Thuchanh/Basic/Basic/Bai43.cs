using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai43
    {
        static void Main()
        {
            Console.WriteLine("Input string: ");
            string str = Console.ReadLine();
            Console.WriteLine(check(str));
            Console.ReadKey();
        }
        static bool check (string str)
        {
            if (str.StartsWith('w'))
            {
                if(str.Substring(1,2) == "ww")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
