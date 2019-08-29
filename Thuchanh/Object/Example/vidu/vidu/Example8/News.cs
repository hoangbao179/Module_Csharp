using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example8
{
    class News : INews
    {
        protected int id;
        protected string title;
        protected string publishDate;
        protected string author;
        protected string content;
        protected string averageRate;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Content { get => content; set => content = value; }
        protected string AverageRate { get => averageRate; }
        public int[] RatesList { get => RateList; set => RateList = value; }

        public void DisPlay()
        {
            Console.WriteLine("Id {0} Title {1} PublishDate {2} Author {3} Context {4} AverageRate {5}", Id, Title, PublishDate, Author, Content, AverageRate);

        }
        public int[] RateList = new int[3];
        public float Calculate()
        {
            var total = 0.0;
            for (int i = 0; i < RateList.Length; i++)
            {
                total += RateList[i];
            }
            return (float)(total / RateList.Length);
        }

    }
}
