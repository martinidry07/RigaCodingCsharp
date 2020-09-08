using System;
using System.Collections.Generic;
using System.Text;

namespace Day07
{
    class Student
    {
        public String Name;
        public String Surname;
        public int Course;

        public Student (String _name, String _surname, int _course)
        {
            this.Name = _name;
            this.Surname = _surname;
            if (_course > 3)
            {
                this.Course  = 3;
            }
            else if (_course < 1)
            {
                this.Course  = 1;
            }
            else
            {
                this.Course  = _course;
            }
        }
        
        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + Course + ". kurss");
        }
    }
}
