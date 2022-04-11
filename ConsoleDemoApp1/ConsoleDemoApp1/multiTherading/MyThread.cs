using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.multiTherading
{
    internal class MyThread
    {

        public void CheckCase()
        {
            string str = "This Is POWER Of MultiThreading In C Sharp";
            foreach (char ch in str)
            {
                Console.Write(ch);
                int code = (int)ch;
                if (code >= 97 && code <= 122)
                {
                    code = code - 32;
                    Thread.Sleep(800);
                    Console.Write("\b");
                    Console.Write((char)code);
                }
                Thread.Sleep(300);
            }
        }

    }

    class MyThreadTest
    {

        static void Main(string[] args)
        {
            Thread th = new Thread(new MyThread().CheckCase);
            th.Start();
        }
       // MyThread test=new MyThread();

        
        
        
    }
}
