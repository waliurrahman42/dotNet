using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day10_23feb
{
    public delegate int MyDelegate(int id , int b);
    
    class Rectangle
    {
        public int AreaOfRec(int l,int b)
        {
            return l * b;
        }

        public  static int Perimeter(int l, int b)
        {
            return (l + b)*2;
        }

    }



    class Circle
    {
        public int AreaOfCircle(int r, int b)
        {
            return (int)(Math.PI*r*r);
        }

        public static int Difrence(int r, int b)
        {
            return (int)(2 * (Math.PI* r));
        }
    }





    internal class DelehgateTest2
    {
        static void Main(string[] args)
        {
           
            MyDelegate myDelegate =new MyDelegate(new Rectangle().AreaOfRec);


            //myDelegate += Rectangle.Perimeter;
            //myDelegate.Invoke(500, 20);
            myDelegate += Circle.Difrence;
            myDelegate += new Circle().AreaOfCircle;
            myDelegate += Rectangle.Perimeter;

            int res =myDelegate.Invoke(2, 4);
            Console.WriteLine(res);

        }
    }
}
