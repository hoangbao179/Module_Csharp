using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.Example8.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string PublishDate { get; set; }
        public string Title { get; set; }
        public float AverageRate { get; set; }
    }
}
