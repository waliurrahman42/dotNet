using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.eventdemo
{

    internal class Publisher
    {
        public event EventHandler EventOfPublisherCube;

        public void  Notify(int num)
        {
            if(EventOfPublisherCube != null)
            {
               // EventOfPublisherCube.Invoke(num);
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
            publisher.Notify(1);

        }

    }
}
