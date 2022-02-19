using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day6
{
    internal static class EmployeeExtension
    {
        public  static void Display(this Employee employee,int x)
        {
            Console.WriteLine($"{employee.FirstName}\t {employee.Age}");
        }

        public static void DisplayAge(this Employee employee)
        {
            Console.WriteLine($"{employee.Age+10}");
        }
    }

    class ExtensionMain
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "rahman";
            employee.Age = 25;
            employee.LastName = "wali";

            employee.Display(1);
            employee.DisplayAge();
        }
    }
}
