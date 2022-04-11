using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.LinqExp
{
    internal class ArrayListDemo2
    {

        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() {10,34,56,57,374,4387,487,435,54,45 };

            Console.WriteLine("list of data using normal loop:");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("list of data using foreach:");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("list of data using Iterator:");
            IEnumerator iterator=list.GetEnumerator();

            /*iterator.MoveNext();
            Console.WriteLine(iterator.Current);
            iterator.MoveNext();
            Console.WriteLine(iterator.Current);*/

            while (iterator.MoveNext())
            {
                Console.WriteLine(iterator.Current);
            }

            int thirddata = (int)list[2]; //boxing/unboxing
            Console.WriteLine("third item "+thirddata);

        }

    }
}
