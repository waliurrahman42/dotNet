using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.eventdemo
{

    public delegate void MyEventHandler1(int num);
    internal class Publisher
    {
        public event MyEventHandler1 Cube;

        public void  Notify(int num)
        {
            if(Cube != null)
            {
                Cube.Invoke(num);
            }
            else
            {
                Console.WriteLine("no subcription");
            }
        }


    }



    internal class EventDemoTest
    {

        
        public void GetCube(int num)
        {
            Console.WriteLine($"cube of {num} is {num*num*num}");
        }



        static void Main(string[] args)
        {

            Publisher publisher = new Publisher();
            publisher.Cube +=new EventDemoTest().GetCube;
            publisher.Notify(5);

        }

    }
}
