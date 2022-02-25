using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day9
{
    internal class MyBase2
    {
        int id;
        public MyBase2(int id)
        {   
            this.id = id;
            Console.WriteLine($"default constructor from myBase2 , id:{this.id}");
            display();
        }
        static MyBase2()
        {
            Console.WriteLine("static constructor from myBase2");
        }

        ~MyBase2()
        {
            Console.WriteLine("distructor from myBase2");
        }

        public void display()
        {
            Console.WriteLine("display from myBase2");
        }
    }

    internal class Drive2:MyBase2
    {
        string name;
        public Drive2(int id, string name) :base(id)
        {   
            this.name = name;
            Console.WriteLine($"default constructor from Drive2 , name :{this.name}");
            display();
            base.display();
        }
        static Drive2()
        {
            Console.WriteLine($"static constructor from Drive2");
        }

        ~Drive2()
        {
            Console.WriteLine($" distructor from Drive2");
        }

        public void display()
        {
            Console.WriteLine("display from Drive2");
        }
    }

    internal class Drive3 : Drive2
    {
        float salary;
        public Drive3(int id,string name,float salary) :base(id,name)
        {
            this.salary = salary;
            Console.WriteLine($"default constructor from Drive3 , salary :{this.salary}");
            display();
            base.display();
        }
        static Drive3()
        {
            Console.WriteLine($"static constructor from Drive3");
        }

        ~Drive3()
        {
            Console.WriteLine($"static distructor from Drive3");
        }

        public void display()
        {
            Console.WriteLine("display from Drive3");
        }
    }

    internal class constructorTest
    {
        static void Main(string[] args)
        {
            Drive3 drive3 = new Drive3(12,"wali",2000.0f);
        }
    }

}
