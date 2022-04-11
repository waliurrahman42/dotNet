using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.assigment.assig4
{

    public delegate String MyDele(string a, string b);

    internal class RemoveComonChar
    {



        //Action<string, string> RemoveDublicate =(string str1,string str2)=>{ 
        //    string temp1 = "";
        //    string temp2 = "";

        //        for (int i = 0; i<str1.Length; i++)
        //        {
        //            if (temp1.Contains(str1[i]))
        //            {
                            //temp1 += str1[i];
        //            }
        //        }
        //        for (int i = 0; i < str2.Length; i++)
        //        {
        //            if (!temp2.Contains(str2[i]))
        //            {
        //                 temp2 += str2[i];
        //            } 
        //        }
        //        Console.WriteLine($"string 1 : {temp1}");
        //        Console.WriteLine($"string 2 : {temp2}");
        //     };





        public static void RemoveDublicate1(string str1, string str2)
        {
            string temp1 = "";
            string temp2 = "";

            for (int i = 0; i < str1.Length; i++)
            {
                if (!temp1.Contains(str1[i]))
                {
                    temp1 += str1[i];
                }
            }

            for (int i = 0; i < str2.Length; i++)
            {
                if (!temp2.Contains(str2[i]))
                {
                    temp2 += str2[i];
                }
            }


            Console.WriteLine($"string 1 : {temp1}");
            Console.WriteLine($"string 2 : {temp2}");

        }

    }
    
}
