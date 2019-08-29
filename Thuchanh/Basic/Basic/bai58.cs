using System;

namespace Basic
{
    class bai58
    {
        public static void Main()
        {
            int[] arrayNumber = { 1, 3, 4, 7, 9 };
            Console.WriteLine(check(arrayNumber));

        }
        public static int check(int[] arrayNumber)
        {
            Array.Sort(arrayNumber);
            int amout = 0;
            for (int i = 0; i < arrayNumber.Length - 1; i++)
            {
                amout += arrayNumber[i + 1] - arrayNumber[i] - 1;
            }
            return amout;
        }
    }
}
