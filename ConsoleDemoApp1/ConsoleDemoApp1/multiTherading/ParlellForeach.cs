using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.multiTherading
{
    internal class ParlellForeach
    {

        static void Main(string[] args)
        {
            List<int> list = Enumerable.Range(10, 20).ToList();
            Console.WriteLine("using foreach");
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("using parllel foreach");
            Parallel.ForEach(list, item =>
            {
                Console.WriteLine(item);
            });
        }
    }
}
