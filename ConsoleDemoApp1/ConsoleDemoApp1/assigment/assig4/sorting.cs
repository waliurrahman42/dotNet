using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.assigment.assig4
{
    public delegate void EventHandlerSort(int[] arr);
    
    //publisher class
    class Publisher1 {

        public event EventHandlerSort SortDescendingEvent;
        public event EventHandlerSort SortAscendingEvent;

        public void Notify(int [] arr)
        {
            if(SortDescendingEvent != null || SortAscendingEvent != null)
            {
                Console.WriteLine("enter 1 to Sort Descending");
                Console.WriteLine("enter 2 to Sort Ascending");
                int ch=int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1: SortDescendingEvent.Invoke(arr);
                            break;
                    
                    case 2 :SortAscendingEvent.Invoke(arr); 
                            break;
                        
                }
            }
            else
            {
                Console.WriteLine("not suscribed any event");
            }


        }

    }

    
    //sorhing class
    internal class SortingDemo
    {
        public void SortDescending(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }

            }
            Console.WriteLine("Sorted: ");
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }

        }


        public void SortAscending(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                for (int j = 0; j < num.Length; j++)
                {
                    if (num[i] < num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }

            }
            Console.WriteLine("Sorted: ");
            foreach (var item in num)
            {
                Console.Write(item + " ");
            }

        }

    }

    
    internal class Test123
    {
        static void Main(string[] args)
        {
            int[] arr = { 34, 43, 43, 43, 5, 54, 76, 8, 982, 23 };
            //SortingDemo st=new SortingDemo();
            //st.SortDescending(arr);
            //st.SortAscending(arr);



            Publisher1 pub = new Publisher1();
            pub.SortAscendingEvent += new SortingDemo().SortAscending;
            pub.SortDescendingEvent += new SortingDemo().SortDescending;
            pub.Notify(arr);
        }
    }

}

