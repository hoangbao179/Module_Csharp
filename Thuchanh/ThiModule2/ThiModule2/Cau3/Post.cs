using System;
using System.Collections.Generic;
using System.Text;
using ThiModule2.Cau3.Model;

namespace ThiModule2.Cau3
{
    public class Post : IPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public float AverageRate { get; private set; }
        int[] Rates = new int[4];
        public NewItem[] ArrayList = new NewItem[100];
        public void DisPlay()
        {
            Console.WriteLine($"{Id} {Title} {Content} {Author} {AverageRate}");
        }
        public float CalculatorRate()
        {
            var total = 0.0;
            for (int i = 0; i < Rates.Length; i++)
            {
                total += Rates[i];
            }
            return (float)(total / Rates.Length);
        }
        public void InsertNew(int index)
        {
            CalculatorRate();
            var newItem = new NewItem()
            {
                Id = Id,
                Author = Author,
                Content = Content,
                Title = Title,
                AverageRate = AverageRate
            };
            ArrayList[index] = newItem;

        }
    }
}
