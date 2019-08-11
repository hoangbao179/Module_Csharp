using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai14
    {
        static void Main()
        {
            int celsiusc;
            Console.WriteLine("Input do c");
            celsiusc = int.Parse(Console.ReadLine());
            Console.WriteLine("Kelvin = " + (celsiusc + 273.15) );
            Console.WriteLine("Fahrenheit = "+ (1.8 * celsiusc + 32));
            Console.ReadKey();

        }
    }
}
