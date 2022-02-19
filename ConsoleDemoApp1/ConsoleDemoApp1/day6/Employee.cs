using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day6
{
    internal class Employee
    {
        int _age;
        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String FullName => $"{FirstName} {LastName}";

        public int Age {
            get => _age;
            set => _age = value;
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee() { FirstName = "wali", LastName = "rahman", Age = 24 };
        }
    }

    
}
