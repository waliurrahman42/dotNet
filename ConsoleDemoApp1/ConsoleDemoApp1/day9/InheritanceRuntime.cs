using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day9
{
    internal class MyBase
    {
        public virtual void Display()
        {
            Console.WriteLine("displayfrom myBase");
        }

    }



    internal class MyDrived: MyBase
    {
        public override void Display()
        {
            Console.WriteLine("dispaly from my derived-2");
        }

    }

    internal class InheritanceDemoMain
    {
        static void Main(string[] args)
        {
            MyDrived drived = new MyDrived();
            drived.Display();
            MyBase myBase = drived;
            myBase.Display();
        }
    }
}
