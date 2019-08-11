using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai25
    {
        static void Main()
        {
            for (int i = 1; i<100; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
