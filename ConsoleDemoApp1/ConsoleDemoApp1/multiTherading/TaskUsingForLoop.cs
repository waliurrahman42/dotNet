using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.multiTherading
{
    internal class TaskUsingForLoop
    {
        static void Main(string[] args)
        {
            DateTime stime=DateTime.Now;
            Console.WriteLine($"For lOop excution started at:{stime.ToLongTimeString()}");
            for (int i = 0; i < 10; i++)
            {
                long sum = DoTask();
                Console.WriteLine($"{i}=>{sum}");
            }
            DateTime etime = DateTime.Now;
            Console.WriteLine($"For lOop excution ended at:{etime.ToLongTimeString()}");
            TimeSpan span = etime - stime;
            int msec=Convert.ToInt32(span.TotalMilliseconds);
            Console.WriteLine($"thime taken to execute { msec}");



        }
       
        


        static long DoTask()
        {
            long sum=0;
            for (int i = 0; i < Int32.MaxValue; i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
