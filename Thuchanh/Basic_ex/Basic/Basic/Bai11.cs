using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai11
    {
        static void Main(string[] arg)
        {
            int age;
            Console.WriteLine("Input Age: ");
            age = int.Parse(Console.ReadLine());
            if (age <= 0)
            {
                age = -age;
            }
            Console.WriteLine("You look older than " + age);
            Console.ReadLine();
        }
    }
}
