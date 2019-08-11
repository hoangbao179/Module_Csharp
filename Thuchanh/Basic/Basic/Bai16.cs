using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai16
    {
        static void Main(string[] args)
        {
            char[] arr;
            Console.WriteLine("Input string");
            string str = Console.ReadLine();
            arr = str.ToCharArray();
            var temp = arr[0];
            arr[0] = arr[arr.Length - 1];
            arr[arr.Length - 1] = temp;
            Console.WriteLine(string.Join("", arr));
        }
    }
}
