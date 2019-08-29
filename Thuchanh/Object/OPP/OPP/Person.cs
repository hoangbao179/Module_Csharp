using System;
using System.Collections.Generic;
using System.Text;

namespace OPP
{   
   
        public class Human
        {
            private int age;
            public void setAge(int num)
            {
                age = num;
            }
            public int getAge()
            {
                return age;
            }
            public virtual void Hello()
            {
                Console.WriteLine("Hello");
            }

        }
        public class Student : Human
        {
            public void GotoClass()
            {
                Console.WriteLine("I going to class");
            }
            public void ShowAge()
            {
                Console.WriteLine("My age is: {0} years old", getAge());
            }
            public override void Hello()
            {
                Console.WriteLine("bao say hello");
            }
        }
        public class Teacher : Human
        {
            private string subject;
            public void Explain()
            {
                Console.WriteLine("Explanation begins");
            }
        }

        public class tessTecher { 
            public static void Main()
                {
                    Human human = new Human();
                    human.Hello();
                    Student student = new Student();
                    student.setAge(21);
                    student.Hello();
                    student.ShowAge();
                    Teacher teacher = new Teacher();
                    teacher.Hello();
                    teacher.setAge(30);
                    teacher.Explain();

        
                }
    }
}

