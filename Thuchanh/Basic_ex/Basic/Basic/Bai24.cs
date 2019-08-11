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
            string[] arrListStr = str.Split(" ");
            int numberfwords = 0;
            string str1 = "";
            
            foreach (string i in arrListStr)
            {
                if(i.Length> numberfwords)
                {
                    numberfwords = i.Length;
                    str1 = i;
                }
            }
            Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
