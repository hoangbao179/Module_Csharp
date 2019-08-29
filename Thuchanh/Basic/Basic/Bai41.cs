using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai41
    {
        static void Main()
        {
            Console.WriteLine("Input String : ");
            string str = Console.ReadLine();
            char[] arrayString;
            arrayString = str.ToCharArray();
            int amout = 0;
            for(int i = 0; i< arrayString.Length; i++)
            {
                if(arrayString[i] == 'w')
                {
                    amout = amout + 1;
                }
            }
            Console.WriteLine(amout <= 3 && amout>0);
            Console.ReadKey();
        }
    }
}
