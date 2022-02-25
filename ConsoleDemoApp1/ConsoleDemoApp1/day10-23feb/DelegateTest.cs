using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day10_23feb
{

    public delegate void MyDelegate1(int x,int y);

    class TestDel1
    {
        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum is:{a + b}");
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference is:{a - b}");
        }
    }

    class TestDel2
    {
        public void Multiply(int a, int b)
        {
            Console.WriteLine($"Multiply is {a * b}");
        }

        public static void Division(int a, int b)
        {
            Console.WriteLine($"Division is {a / b}");
        }

    }

    internal class DelegateTest
    {

        static void Main(string[] args)
        {
            MyDelegate1 myDelegate = new MyDelegate1(new TestDel1().Add);
            

            myDelegate += TestDel1.Subtract;
            myDelegate.Invoke(500, 20);
            myDelegate  +=TestDel2.Division;
            myDelegate += new TestDel2().Multiply;

            myDelegate.Invoke(50, 40);
        }
    }
}
