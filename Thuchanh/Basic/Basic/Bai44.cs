using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai44
    {
        static void Main()
        {
            Console.WriteLine("Input string: ");
            string str = Console.ReadLine();
            Console.WriteLine(stringOdd(str));
            Console.ReadLine();
        }
        static string stringOdd( string str)
        {
            string str1 = "";
            char[] arrayString = str.ToCharArray();
            for(int i = 0; i<arrayString.Length; i++)
            {
                if(i%2 == 1)
                {
                    str1 = str1 + arrayString[i];
                }
            }
            return str1;
        }
    }
}
