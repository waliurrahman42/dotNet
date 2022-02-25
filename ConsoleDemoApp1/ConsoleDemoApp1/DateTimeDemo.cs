using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1
{
    internal class DateTimeDemo
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToString("MM/dd/yyyy"));
            Console.WriteLine(dt.Date);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Year);
            dt = dt.AddMonths(5);
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToString("dddd , MMMM, yy"));
            Console.WriteLine(dt.ToString("dd, MM, yy,HH:mm:ss tt "));
            Console.WriteLine(dt.ToString("dd-MM-yy , HH:mm:ss"));
            DateTime.Now.ToString("yyyy’-‘MM’-‘dd’T’HH’:’mm’:’ss");
            // DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
        }
    }
}
