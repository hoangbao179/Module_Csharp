using System;
using System.Collections.Generic;
using System.Text;
using vidu.Example7.Models;

namespace vidu.Example7
{
    public class News : INews
    {
        protected int id;
        protected string title;
        protected string publicshDate;
        protected string author;
        protected string content;
        protected double averageRate;

        public int[] RateList = new int[3];
        public NewItem[] ArrayList = new NewItem[100];
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublisDate { get => publicshDate; set => publicshDate = value; }
        public string Author { get => author; set => author = value; }
        public double AverageRate { get => averageRate; set => averageRate = value; }
        public string Content { get => content; set => content = value; }
        public void DisPlay()
        {
            foreach (var newItem in ArrayList)
            {
                if (newItem != null)
                {
                    Console.WriteLine("Id {0} Title {1} PublishDate {2} Author {3} Content {4} AverageRate {5}",
                                newItem.Id, newItem.Title,
                                newItem.PublisDate, newItem.Author,
                                newItem.Content, newItem.AverageRate);
                }
            }
        }
        public void Calculate()
        {
            var total = 0.0;
            for (int i = 0; i < RateList.Length; i++)
            {
                total += RateList[i];
            }
            averageRate = (double)(total / RateList.Length);
        }

        public void InsertNew(int index)
        {
            Calculate();
            var newItem = new NewItem()
            {
                Id = id,
                Author = author,
                Content = content,
                PublisDate = publicshDate,
                Title = title,
                AverageRate = averageRate
            };
            ArrayList[index] = newItem;

        }

    }
}
