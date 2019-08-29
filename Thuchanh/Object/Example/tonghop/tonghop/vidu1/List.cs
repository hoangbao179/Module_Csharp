using System;
using System.Collections.Generic;
using System.Text;

namespace tonghop.vidu1
{
    public class List
    {
        public static void Main()
        {
            List<Dictionary<int, Member>> C6 = new List<Dictionary<int, Member>>();
            var to1 = new Dictionary<int, string>();
            to1.Add(1, "khoa nguyen");
            to1.Add(2, "Bao nguyen");
            C6.Add(to1);

            //var to2 = new Dictionary<int, string>();
            //to2.Add(1, "bao dep trai");
            //to2.Add(2, "sinh kute");
            //C6.Add(to2);

            foreach (var to in C6)
            {
                foreach (var member in to)
                {
                    Console.WriteLine("Id: {0}, Name: {1}", member.Key, member.Value);
                }
                
            }

        }
    }
    public class Member
    {
        public string Name { get; set; }
        public string DOB { get; set; }
    }
}
