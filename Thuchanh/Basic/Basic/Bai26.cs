using System;
using System.Collections.Generic;
using System.Text;

namespace Basic
{
    class Bai26
    {
        static bool prime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main()
        {

            int amout = 0, sum = 0, num = 2;
            while (amout < 500)
            {

                if (prime(num))
                {
                    sum = sum + num;
                    amout = amout + 1;
                }
                num = num + 1;

            }
            Console.WriteLine(sum);

        }
    }
}
            
          
    

