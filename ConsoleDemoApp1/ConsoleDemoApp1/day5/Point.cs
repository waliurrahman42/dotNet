using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day5
{
    internal class Point
    {
        int x;
        int y;

        public Point()
        {
            this.x = 20;
            this.y = 30;
        }
        public Point(int x=50, int y=20)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Point{x},{y}";
        }


        static void Main(string[] args)
        {

            Point point1 = new Point();

            Point point2 = new Point(30,40);
            Point point3 = new Point(80);
            Point point4 = new Point(y:60) ;
            Point point5 = new Point(x:90);
            Point point6 = new Point(y:100,x:105);
            Point point7 = new Point();


        }

    }
}
