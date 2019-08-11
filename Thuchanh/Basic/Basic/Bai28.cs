using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai28
    {
        static void Main()
        {
            Console.WriteLine("Input string");
            string str = Console.ReadLine();
            Console.WriteLine(reverse1(str));
        }
        static string reverse1( string str)
        {
            string[] arrayString = str.Split(" ");
            string temp ="";
            for (int i = 0; i<arrayString.Length/2; i++)
            {
                temp = arrayString[i];
                arrayString[i] = arrayString[arrayString.Length - 1 - i];
                arrayString[arrayString.Length - 1 - i] = temp;

            }
            return string.Join(" ", arrayString);
        }
    }
}
