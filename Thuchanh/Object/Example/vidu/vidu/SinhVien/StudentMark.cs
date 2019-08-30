using System;
using System.Collections.Generic;
using System.Text;

namespace vidu.SinhVien
{
    public class StudentMark : IStudentMark
    {
        private string fullName;
        private string classRoom;
        private int id;
        private int semester;
        private double averageMark;
        public string FullName { get => fullName; set => fullName = value; }
        public string ClassRoom { get => classRoom; set => classRoom = value; }
        public int Id { get => id; set => id = value; }
        public int Semester { get => semester; set => semester = value; }
        public double AverageMark { get => averageMark; private set => averageMark = value; }

        public void DisPlay()
        {
            Console.WriteLine("id full name");
        }
    }
}
