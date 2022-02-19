using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1
{
    internal class Seconds
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string st = Console.ReadLine();
            //string st = "Createamethodthattakc esastringandret urnsthenumberof wwW";
            string alph = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            String contstr;
            int count = 0;
            int dublicateCnt =0;
            for (int i = 0; i < alph.Length; i++)
            {
                for (int j = 0; j < st.Length; j++)
                {
                    if (alph[i] == st[j])
                    {
                        count++;
                    }
                }
                if (count>1)
                {
                    dublicateCnt++;
                }
                //contstr = alph[i] + "=" + count;
                //Console.WriteLine(contstr);
                contstr = "";
                count = 0;
            }

            Console.WriteLine("total duplicate= "+dublicateCnt);
        }
    }
}
