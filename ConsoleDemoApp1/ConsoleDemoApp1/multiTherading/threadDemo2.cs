using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.multiTherading
{


    class Test3
    {
        public static void Print(Object ob)
        {
            Console.WriteLine("\n Running Thread:" + Thread.CurrentThread.Name +
                "\tPooled Thread: " + Thread.CurrentThread.IsThreadPoolThread);
        }

        public static void processWithThreadMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread obj =new Thread(new ParameterizedThreadStart(Test3.Print));
                obj.Name = "th-" + i;
                obj.Start();
            }
        }

        public static void ProcessWithThreadPoolMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                ThreadPool.QueueUserWorkItem(Test3.Print);
            }
        }



    }

    internal class threadDemo2
    {

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            Console.WriteLine("\n normal thread execution");
            watch.Start();
            Test3.processWithThreadMethod();
            watch.Stop();
            Console.WriteLine("time consumed: "+ watch.ElapsedTicks);
            Console.WriteLine("time consumed: " + watch.ElapsedMilliseconds);


            Console.WriteLine("\n threadPool execution");
            watch.Start();
            Test3.ProcessWithThreadPoolMethod();
            watch.Stop();
            Console.WriteLine("time consumed: "+ watch.ElapsedTicks);
            Console.WriteLine("time consumed: " + watch.ElapsedMilliseconds);
            Console.WriteLine("main ended");
        }
    }
}
