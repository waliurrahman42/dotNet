using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day10_23feb
{
    interface Icalc1
    {

        int Add(int x,int y);//public and abstract

        
    }

    interface Icalc2
    {

        int sub(int x, int y);//public and abstract


    }

    class Calculator : Icalc1, Icalc2
    {
        public int Add(int x, int y)
        {
           return x + y;
        }

        public int sub(int x, int y)
        {
            return x + y;
        }
    }


    internal class InterfaceDemo1
    {
        static void Main(string[] args)
        {

        }
    }
}
