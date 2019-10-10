using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace C1
{
    public class Student
    {
        private decimal gpa;
        private string lname, fname;
        private int stuid;
        public string LastName
        {
            private set
            {
                if (value != null && value != "") lname = value;

            }
            get
            {
                return lname;
            }

        }
        public string FirstName
        {
            private set
            {
                if (value != null && value != "") fname = value;

            }
            get
            {
                return fname;
            }

        }
        public int Stuid
        {

            private set
            {
                if (value > 0) stuid = value;
            }
            get { return stuid; }
        }
        public decimal GPA
        {
            private set
            {
                if (gpa >= 0 && gpa <= 4) gpa = value;
            }
            get
            {
                return gpa;
            }
        }
        public string Classification { get; set; }
        public string Major { get; set; }
        public Student(string fname, string lname, int stuid, decimal gpa, string cls, string major)
        {
            FirstName = fname;
            LastName = lname;
            Stuid = stuid;
            GPA = gpa;
            Classification = cls;
            Major = major;

        }
        public string ToString()
        {
            return $"{FirstName} {LastName}, ID# {Stuid}\n GPA={GPA:f2}\n Classification {Classification}\n {Major} major";
        }

    }

    class runStudent
    {
        static void Main()
        {
            Student me = new Student("Khiet", "Lam", 1373461, 4, "graduate", "MIS");
            WriteLine(me.ToString());
        }


    }
}
