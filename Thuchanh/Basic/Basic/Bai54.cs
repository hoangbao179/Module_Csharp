using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai54
    {
        static void Main()
        {
            Console.WriteLine("Input year: ", 100);
            int year = Convert.ToInt32(Console.ReadLine());
            if (year == 0) Console.WriteLine("Century 0");
            else if (year % 100 == 0) Console.WriteLine("Century " + year / 100);
            else Console.WriteLine("Century "+ ((year/100)+1));
            Console.ReadKey();
        }
    }
}
