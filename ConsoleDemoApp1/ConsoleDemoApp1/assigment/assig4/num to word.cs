using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.assigment.assig4
{
    internal class NumTo_Word
    {


        public void NumToWord(string num)
        {
            char[] str=num.ToCharArray();
            string[] ZeroToNine =  {"zero","one ","two ","three","four","five","six","seven","eight","nine"};
            String[] elevenToNineteen = { "ten", "Eleven", "Twelve", "Thirteen", " Fourteen", "Fifteen", "six", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            String[] tenToNintey = {"Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            String[] hundredThosand = { "hundred", "thousand" };
            String[] store = new string[num.Length];

            if (num.Length == 4)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 48) { store[i] = ZeroToNine[0]; }
                    else if (str[i] == 49) { store[i] = ZeroToNine[1]; }
                    else if (str[i] == 50) { store[i] = ZeroToNine[2]; }
                    else if (str[i] == 51) { store[i] = ZeroToNine[3]; }
                    else if (str[i] == 52) { store[i] = ZeroToNine[4]; }
                    else if (str[i] == 53) { store[i] = ZeroToNine[5]; }
                    else if (str[i] == 54) { store[i] = ZeroToNine[6]; }
                    else if (str[i] == 55) { store[i] = ZeroToNine[7]; }
                    else if (str[i] == 56) { store[i] = ZeroToNine[8]; }
                    else if (str[i] == 57) { store[i] = ZeroToNine[9]; }

                    
                }

                //for (int i = 0; i < str.Length; i++)
                //{
                //    for (int j = 0; j < str.Length; j++)
                //    {
                //        if (store[i].Equals(ZeroToNine[j])) {

                //            Console.WriteLine("h=thodand");
                //        }
                //    }
                   
                //}



                string st = string.Join(" ", store);
                Console.WriteLine(st);
            }
            else if (num.Length == 5)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 48)      { store[i] = ZeroToNine[0];}
                    else if (str[i] == 49) { store[i] = ZeroToNine[1];}
                    else if (str[i] == 50) { store[i] = ZeroToNine[2];}
                    else if (str[i] == 51) { store[i] = ZeroToNine[3];}
                    else if (str[i] == 52) { store[i] = ZeroToNine[4];}
                    else if (str[i] == 53) { store[i] = ZeroToNine[5];}
                    else if (str[i] == 54) { store[i] = ZeroToNine[6];}
                    else if (str[i] == 55) { store[i] = ZeroToNine[7];}
                    else if (str[i] == 56) { store[i] = ZeroToNine[8];}
                    else if (str[i] == 57) { store[i] = ZeroToNine[9];}
                }

                string st = string.Join(" ", store);
                Console.WriteLine(st);
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }


        static void Main(string[] args)
        {
            NumTo_Word num=new NumTo_Word();

            num.NumToWord("0456");
        }

    }
}
