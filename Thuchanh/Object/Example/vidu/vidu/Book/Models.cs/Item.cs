using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Book.Models.cs
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PublishDate { get; set; }
        public string Author { get; set; }
        public string Language { get; set; }
        public float AveragePrice { get; set; }
    }
}
