using System;
using System.Collections.Generic;
using System.Text;

namespace vidu
{
    public class XuLiNgoaiLe
    {
        public static void Main()
        {
            Console.WriteLine("Nhap a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b");
            int b = Convert.ToInt32(Console.ReadLine());
            PhepChia(a,b);
            
        }
        public static void PhepChia(int num1, int num2)
        {
            double c = 0 ;
            try
            {
                c = num1 / num2;
                Console.WriteLine("{0}:{1} = {2}",num1,num2,c);
              
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("So nhap sai");
            }

        }
    }
}
