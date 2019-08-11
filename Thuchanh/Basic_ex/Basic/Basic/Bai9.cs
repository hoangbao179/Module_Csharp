using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai9
    {
        static void Main(string[] arg)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Input num1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input num2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input num3: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input num4: ");
            num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("average :" + (num1 + num2 + num3 + num4) / 4);
            Console.ReadLine();
        }
    }
}
