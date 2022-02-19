using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day4
{
    internal class Employee
    {
        int IdNo;
        String Name;
        static int id;


        public Employee()
        {
            Console.WriteLine("default constructor");
            //this.IdNo = 1000;
            this.IdNo = id++;
            this.Name = "admin";
        }

        public Employee(int IdNo)
        {
            Console.WriteLine(  "parametrized for id");
            this.IdNo= IdNo;
            id = IdNo+1;
        }

        public Employee(String Name)
        {
            Console.WriteLine("parametrized for name");
            this.Name= Name;
            this.IdNo = id++;
        }

        public Employee(int IdNo,String Name)
        {
            Console.WriteLine("parametrized for id and name");
            this.IdNo = IdNo;
            
            this.Name = Name;
            id = IdNo + 1;
        }


        //static constructor

        static Employee()
        {
            Console.WriteLine("static constructor ");
            id = 1000;
        }



        public void SetEmpData(int IdNo,string Name)
        {
            this.IdNo = IdNo;
            this.Name = Name;

        }
        public void DisplayEmpData()
        {

            Console.WriteLine($"id:{IdNo}\tName:{Name}");
        }

        public override string ToString()
        {
            return $"id:{IdNo}\tName{Name}";
        }

    }


    class EmployeeMain
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.DisplayEmpData();

            //Employee emp1=new Employee();
            //emp1.SetEmpData(1000, "wali");

            //Console.WriteLine(emp1);

            Employee emp2 = new Employee();
            Console.WriteLine(emp2);
            Employee emp3 = new Employee(43);
            Console.WriteLine(emp3);

            Employee emp4 = new Employee("wali");
            Console.WriteLine(emp4);

            Employee emp5 = new Employee(25,"darood");
            Console.WriteLine(emp5);



        }
    }
}
