using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ConsoleDemoApp1.day7;

namespace ConsoleDemoApp1.LinqExp
{
    internal class LinqDemo1
    {

        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            //var evenNums = from num in numbers
            //               where num % 2 == 0
            //               select num;

            //Console.WriteLine("even numbers:");
            //foreach (var item in evenNums)
            //{
            //    Console.WriteLine(item);
            //}


            //ArrayList list=new ArrayList()
            //                { 
            //                    10,"mumbai","patna",30,25,"patna",
            //                    new Product(){PId=1000}
                
            //                };
            //list.Add(100);

            //var nums =from n in list.OfType<int>()
            //          where n % 2 == 0
            //          select n;

            //Console.WriteLine("list data");
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}



            int[][] arr = new int[3][]
                {
                    new int[]{1,2,3,4 },
                    new int[]{100,200 },
                    new int[]{14,35,46,54, }
                };

            var maxarr= arr.Select(i => i.Max()).ToArray();

            foreach (var item in maxarr)
            {
                Console.WriteLine(item);
            }

            List<string> names = new List<string>()
                        {
                            "Sunil kumar",
                             "Table kumar",
                             "Manoj yadav",
                             "Aman sdhish",
                             "waliur rahman",
                             

                        };

            var result= from name in names
                        where name.EndsWith("kumar")
                        orderby name ascending
                        select name;

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
