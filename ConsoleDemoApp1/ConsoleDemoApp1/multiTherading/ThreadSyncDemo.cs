using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.multiTherading
{

    class ThreadSyncDemoClass
    {


        public void Print()
        {
            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"running thread :"
                        + $"{Thread.CurrentThread.Name}\tvalue of i:{i}");
                }
            }


            GetRandom = new Random().Next(1, 50);
        }

        public int GetRandom
        {
            get;
            set;
        }


    }



    internal class ThreadSyncDemoTest
    {
        static void Main(string[] args)
        {
            ThreadSyncDemoClass tsy = new ThreadSyncDemoClass();
            Thread th1 = new Thread(tsy.Print);
            th1.Name = "thread--1";
            th1.Start();

            Thread th2=Thread.CurrentThread;
            th2.Name = "Main thread";

            lock (tsy)
            {
                for (int i = 0; i < tsy.GetRandom; i++)
                {
                    Console.WriteLine($"running thread :"
                      + $"{Thread.CurrentThread.Name}\tvalue of i:{i}");
                }
            }

        }
        
    }
}
