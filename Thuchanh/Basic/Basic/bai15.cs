using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class bai15
    {
        static void Main(string[] args)
        {
            int index;
            
            Console.WriteLine("Input String");
            string str = Console.ReadLine();
            Console.WriteLine("Input index");
            index = int.Parse(Console.ReadLine());
            Console.WriteLine(str.Remove(index,1));
            Console.ReadLine();
        }
    }
}
