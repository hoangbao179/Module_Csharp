using System;
using System.Collections.Generic;
using System.Text;
using vidu.SinhVien.Model;

namespace vidu.SinhVien
{
    public class Student : IStudent
    {
        public string FullName { get; set; }
        public int Id { get; set; }
        public string DateOfBirth { get; set; }
        public string Native { get ; set ; }

        public string ClassRoom { get; set; }
        public string PhoneNo { get; set; }
        public int Mobile { get; set; }
        public void DisPlay()
        {
            Console.WriteLine($"{FullName} {Id} {DateOfBirth}");
        }
    }
}
