using System;
using System.Collections.Generic;
using System.Text;

namespace tonghop.vidu1
{
    public class StackQueue
    {
        public static void Main()
        {
            Stack<int> Money = new Stack<int>();
            Money.Push(500000);
            Money.Push(200000);
            Money.Push(100000);
            foreach (var item in Money)
            {
                Console.WriteLine("Value: {0}", item);
            }
            //for (int i = 0; i < Money.Count; i++)
            //{
            //    Console.WriteLine("Value: {0}", item);
            //}
            Console.WriteLine("----------------------");
            Console.WriteLine("Item on top : {0}", Money.Peek());
            Console.WriteLine("----------------------");
            Queue<string> Task = new Queue<string>();
            Task.Enqueue("Build project");
            Task.Enqueue("Eat rice");
            Task.Enqueue("Assign tasks");
            foreach (var item in Task)
            {
                Console.WriteLine("Value: {0}", item);
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Item on top: {0}",Task.Peek());
        }
    }
}
