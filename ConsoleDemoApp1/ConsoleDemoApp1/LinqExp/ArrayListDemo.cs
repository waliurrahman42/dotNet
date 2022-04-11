using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.LinqExp
{
    internal class ArrayListDemo
    {


        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(5);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            list.Add(20);
            Console.WriteLine("curernt count :  "+list.Count);
            Console.WriteLine("curernt capacity :  " + list.Capacity);
            int[] arr = {1,2,3,4,5,6};

            list.AddRange(arr);

            Console.WriteLine("curernt count :  " + list.Count);
            Console.WriteLine("curernt capacity :  " + list.Capacity);
            
            list.TrimToSize();

            Console.WriteLine("curernt count :  " + list.Count);
            Console.WriteLine("curernt capacity :  " + list.Capacity);


        }
    }
}
