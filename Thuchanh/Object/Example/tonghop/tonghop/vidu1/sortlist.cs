using System;
using System.Collections.Generic;
using System.Text;

namespace tonghop.vidu1
{
    public class example
    {
        public static void Main()
        {
            //SortedList<string, string> EmloyeeList = new SortedList<string, string>();
            Dictionary<string, string> EmloyeeList = new Dictionary<string, string>();
            // add item
            EmloyeeList.Add("Khoa", "Co tuong");
            EmloyeeList.Add("Bao", "hat ho");
            EmloyeeList.Add("Nhan", "choi game");
            ////show all by value
            //Console.WriteLine("Show all value");
            //foreach(var item in EmloyeeList.Values)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------");
            ////show all key
            //foreach (var key in EmloyeeList.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //Console.WriteLine("----------------------");
            //foreach (var key in EmloyeeList.Keys)
            //{
            //    Console.WriteLine("Key: {0} Value: {1}",key,EmloyeeList[key]);
            //}
            ////remove by key
            //Console.WriteLine("----------------------");
            //EmloyeeList.Remove("Khoa");
            //foreach (var key in EmloyeeList.Keys)
            //{
            //    Console.WriteLine("Key: {0} Value: {1}", key, EmloyeeList[key]);
            //}

            ////remove return by value
            //Console.WriteLine("----------------------");
            //string Nhanvalue;
            //EmloyeeList.Remove("Nhan", out Nhanvalue);
            //Console.WriteLine(Nhanvalue);
            //Console.WriteLine("----------------------");
            //foreach (var key in EmloyeeList.Keys)
            //{
            //    Console.WriteLine("Key: {0} Value: {1}", key, EmloyeeList[key]);
            //}
            //Console.WriteLine("----------------------");
            //remove item by index
            //EmloyeeList.RemoveAt(EmloyeeList.Count - 1);
            //foreach (var key in EmloyeeList.Keys)
            //{
            //    Console.WriteLine("Key: {0} Value: {1}", key, EmloyeeList[key]);
            //}
            //show all value by using enumnator
            Console.WriteLine("----------------------");
            var enumnator = EmloyeeList.GetEnumerator();
            while (enumnator.MoveNext())
            {
                Console.WriteLine("Key: {0}\t value: {1}", enumnator.Current.Key, enumnator.Current.Value);
            }
            // show all value reverse
            //Console.WriteLine("----------------------");
            //for (int i = EmloyeeList.Count; i >=0; i--)
            //{
            //    Console.WriteLine("Key: {0} Value: {1}",);
            //}
        }
    }
}
