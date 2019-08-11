using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai8
    {
        static void Main( string[] arg)
        {
            int num, i;
            Console.WriteLine("Input number");
            num = int.Parse(Console.ReadLine());
            for(i=0; i<=10; i++)
            {
                Console.WriteLine(num + "*" + i + "=" + num * i);
                
            }
            Console.ReadLine();
        }
    }
}
