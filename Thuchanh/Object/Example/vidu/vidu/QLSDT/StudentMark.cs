using System;
using vidu.QLSDT.Models;
using System.Collections;
using System.Collections.Generic;

namespace vidu.QLSDT
{
    public class StudentMark : IStudentMark
    {
        private string fullName;
        private int id;
        private string className;
        private int semester;
        private float averageMark;

        public string FullName { get => fullName; set => fullName = value; }
        public int Id { get => id; set => id = value; }
        public string ClassName { get => className; set => className = value; }
        public int Semester { get => semester; set => semester = value; }
        public float AverageMark { get => averageMark; private set => averageMark = value; }

        public int[] SubjectMarkList = new int[5];
        public StudentItem[] ArrayList = new StudentItem[10];
        public void DisPlay()
        {
            foreach (var item in ArrayList)
            {
                if (item != null)
                {

                    Console.WriteLine("Full name: {0}\t Id : {1}\t Classroom: {2}\t Semester: {3}\t AverageMark: {4}", item.FullName, item.Id, item.ClassName, item.Semester, item.AverageMark);
                }
            }
        }
        public void AveCal()
        {
            var total = 0.0;
            for (int i = 0; i < SubjectMarkList.Length; i++)
            {
                total += SubjectMarkList[i];
            }
            averageMark = (float)(total / SubjectMarkList.Length);
        }
        public void InsertNew(int num)
        {
            AveCal();
            var studentItem = new StudentItem()
            {
                Id = id,
                FullName = fullName,
                ClassName = className,
                Semester = semester,
                AverageMark = averageMark

            };
            ArrayList[num] = studentItem;

        }
        //public float AverageStudent()
        //{
        //    var totals = 0.0;
        //    foreach (var item in ArrayList)
        //    {
        //        totals += item.AverageMark;
        //    }
        //    return (float)(totals / ArrayList.Length);
        //}
    }
}
