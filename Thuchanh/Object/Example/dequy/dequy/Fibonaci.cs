using System;
using System.Collections.Generic;
using System.Text;

namespace dequy
{
    public class Fibonaci
    {
        public static void Main()
        {
            Console.WriteLine(Giaithua(10));
            Console.WriteLine("fibo : {0}", Fibo(20));
        }
        public static long Giaithua(int n)
        {
            if (n == 1)
                return 1;
            return n * Giaithua(n - 1);
        }
        public static long Fibo(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return Fibo(n - 1) + Fibo(n - 2);
        }
    }
}
