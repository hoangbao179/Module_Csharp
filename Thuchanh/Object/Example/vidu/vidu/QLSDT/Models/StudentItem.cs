using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.QLSDT.Models
{
    public class StudentItem
    {
        public string FullName { get ; set; }
        public int Id { get; set; }
        public string ClassName { get; set; }
        public int Semester { get; set; }
        public float AverageMark { get; set;}
    }
}
