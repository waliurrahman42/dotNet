using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day10_23feb
{
    class FuncDelegate
    {
        public static int AddFunc(int x, int y, int z)
        {
            return x + y + z;
        }

        public static void sumAction(int x, int y, int z)
        {
            Console.WriteLine($"sum is action delegate{x + y + z}");
        }

    }
   
    
    
    internal class DelegateAction
    {
      
        static void Main(string[] args)
        {


            Func<int, int, int, int> funcAdd = FuncDelegate.AddFunc;
            int sum = funcAdd(2, 5, 5);

            Console.WriteLine($"{sum}");

            //Action
            Action<int> print = delegate (int i)
            {
                Console.WriteLine($"{i}");
            };

            print(100);

            Action<int, int, int> actionAdd = FuncDelegate.sumAction;
            actionAdd(30, 45, 54);

            Action<int> square1 = (int n) => { Console.WriteLine($"{n}is {n * n}"); };
            square1(5);
        
            Action<int> square = n => Console.WriteLine($"{n}is {n*n}");
            square1(6);



            //predicate
            Predicate<string> predicate = str => str.Equals(str.ToLower());

            Console.WriteLine(predicate("cdac123"));
            Console.WriteLine(predicate("cDac123"));
            Console.WriteLine(predicate("cdAC123"));
            Console.WriteLine(predicate("cdFc123"));



        }
    }
}
