using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai30
    {
        static void Main()
        {
            Console.WriteLine("Input HEX");
            string hex = Console.ReadLine();
            int num = int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(num);
        }
    }
}
