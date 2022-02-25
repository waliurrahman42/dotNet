using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace UsePrivateAssembly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCalc cal = new MyCalc();
            Console.WriteLine(cal.Add(1,3));
            Console.WriteLine(cal.Muyltiply(1, 3));
        }
    }
}
