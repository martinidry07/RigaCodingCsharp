using System;
using System.Collections.Generic;
using System.Text;

namespace Day06
{
    class Student
    {
        public String Name;
        public String Surname;

     


        private int _course;
        public int Course
        {
            get
            {
                return _course;
            }
            set
            {
                if (value > 3)
                {
                    _course = 3;
                }
                else if (value < 1)
                {
                    _course = 1;
                }
                else
                {
                    _course = value;
                }

            }
        }
        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + Course + ". kurss");
        }

    }

}


