using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai55
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 5, 6, 7, 7, 8, 9, 11 };
            Console.WriteLine("Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(check(arr,number)) ;
            Console.ReadKey();

        }
        static bool check( int[] arr, int number)
        {
            for( int i = 0; i <arr.Length; i++)
            {
                if(arr[i]*arr[i+1] == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
