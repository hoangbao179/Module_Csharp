using System;
using System.Collections.Generic;
using System.Text;
using vidu.Book.Models.cs;

namespace vidu.Book
{
    public class Book : Ibook
    {
        private int id;
        private string name;
        private string publishDate;
        private string author;
        private string language;
        private float averagePrice;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string PublishDate { get => publishDate; set => publishDate = value; }
        public string Author { get => author; set => author = value; }
        public string Language { get => language; set => language = value; }
        public float AveragePrice { get => averagePrice; private set => averagePrice = value; }

        public int[] PriceList = new int[5];
        public Item[] ArrayList = new Item[100];
        public void DisPlay()
        {
            foreach (var item in ArrayList)
            {
                if (item != null)
                {
                    Console.WriteLine("Id: {0}\t Name: {1}\t PublishDate: {2}\t Author: {3}\t Language: {4}\t AveragePrice: {5}\t", item.Id, item.Name, item.PublishDate ,item.Author, item.Language, item.AveragePrice);
                }
            }

        }
        public void Calculate()
        {
            var total = 0.0;
            foreach (var item in PriceList)
            {
                total += item;
            }
            averagePrice = (float)(total / PriceList.Length);
        }
        public void InsertNew(int num)
        {
            Calculate();
            Item item = new Item()
            {
                Id = id,
                Name = name,
                Language = language,
                Author = author,
                PublishDate = publishDate,
                AveragePrice = averagePrice
            };
            ArrayList[num] = item;
        }
    }
    
}
