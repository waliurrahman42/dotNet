using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day6
{
    internal class Student
    {
        int _RollNo;
        int _Age;
        String _Name;
        string _Course;
        static string _collage;

        static Student()
        {
            _collage = "Astric";
        }


        public int RollNo
        {
            get { 
                return _RollNo; 
            }
            set 
            { 
                _RollNo = value; 
            }
        }

        public String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }

        public override string ToString()
        {
            return $"Roll:{_RollNo}\tname:{_Name}\tage:{_Age}"; 
        }

    }

    class StudentMain
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.RollNo = 20;
            st.Name = "wali";
            st.Age = 18;

            Console.WriteLine($"{st.RollNo}\t{st.Name}\t{st.Age}");
            Console.WriteLine(st);

            Student st1 = new Student
            {
                RollNo = 40,
                Name = "wali"
            };
        }
    }
}
