using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleDemoApp1.multiTherading
{
    internal class ThreadDemo
    {
        class test1
        {
            public void print()
            {
                lock (this) { 
                    int i=1;
                    for(;i<5 ; )
                    {
                        Console.WriteLine($"test 1 ======={Thread.CurrentThread.Name}  runnig: ");
                        Thread.Sleep(1000);
                    }
                }
            }
        }

        class test2
        {
            public void print()
            {
                int i=1;
                for (; ; )
                {
                    Console.WriteLine($"test 2 **********{Thread.CurrentThread.Name} runnig: {i*i}");
                    i++;
                    Thread.Sleep(500);
                }
            }
        }

        static void Main(string[] args)
        {
            //Thread t1=Thread.CurrentThread;
            //t1.Name = "Main Thread";
            //t1.Priority = ThreadPriority.Highest;
            //Console.WriteLine("name:"+t1.Name);
            //Console.WriteLine("Priority:" + t1.Priority);
            //Console.WriteLine("IsAlive:" + t1.IsAlive);
            //Console.WriteLine("IsBackground:" + t1.IsBackground);
            //Console.WriteLine("ThreadState:" + t1.ThreadState);
            //Console.WriteLine("IsThreadPoolThread:" + t1.IsThreadPoolThread);
        
            test1 t1 = new test1();
            test2 t2 = new test2();
            //t1.print();
            //t2.print();

            Thread th1=new Thread(t1.print);
            th1.Name = "th-1";
            Thread th2 = new Thread(t1.print);
            th2.Name = "th-2";
            th1.Start();
            th2.Start();

            Thread th3 = new Thread(t2.print);
            th3.Name = "th-3";
            Thread th4 = new Thread(t2.print);
            th4.Name = "th-4";
            th3.Start();
            th4.Start();



        }
    }
}
