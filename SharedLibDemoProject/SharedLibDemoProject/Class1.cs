using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibDemoProject
{
    public class SharedLibrary
    {
        public void Display()
        {
            Console.WriteLine("dispaly for SharedLibrary virsion -1 ");
        }

        public void Show()
        {
            Console.WriteLine("dispaly for SharedLibrary virsion -2 ");
        }
    }

    public class Calculator
    {
        public int Add(int x, int y,int z)
        {
           return x+ y + z;
        }
    }
}
