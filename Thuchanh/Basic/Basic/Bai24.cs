using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai24
    {
        static void Main()
        {
            Console.WriteLine("Input string");
            string str = Console.ReadLine();
            Console.WriteLine(wordLength(str));
            Console.ReadKey();
        }
        static string wordLength(string str)
        {
            string[] arrListStr = str.Split(" ");
            int numberOfWords = 0;
            string str1 = "";
            foreach (string i in arrListStr)
            {
                if (i.Length > numberOfWords)
                {
                    numberOfWords = i.Length;
                    str1 = i;
                }

            }
            return str1;
        }
    }
}