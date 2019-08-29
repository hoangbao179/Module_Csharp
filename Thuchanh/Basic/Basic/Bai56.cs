using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai56
    {
        static void Main()
        {
            Console.WriteLine("Input string");
            string str = Console.ReadLine();
            char[] arrayString = str.ToCharArray();
            int amout = 0;
            for(int i =0; i<arrayString.Length; i++)
            {
                if(arrayString[i]!= arrayString[arrayString.Length - 1 - i])
                {
                    amout = amout + 1;
                }
            }
            Console.WriteLine(amout == 0);
        }
    }
}
