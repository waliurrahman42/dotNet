using ConsoleDemoApp1.assigment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.assigment
{
    internal class assign2
    {

        //public void MaskedString(ConsoleKeyInfo ck)
        //{
        //    string CardNo = "";

        //    while (ck.Key != ConsoleKey.Enter)
        //    {
        //        Console.Write("#");
        //        CardNo += ck.KeyChar;
        //        ck = Console.ReadKey(true);
        //    }
        //    Console.WriteLine("\nEntered Password is: " + CardNo);
        //}

        //masking
        public void Masked(String str){
            char []CardNo = new char[str.Length];

            if (str.Length >= 4){
                for (int i = 0; i < str.Length-4; i++){
                   CardNo[i] = (char)35;
                }
                for (int i = str.Length-4; i<str.Length; i++){
                    CardNo[i] = str[i];
                }
                string maskedString=new string(CardNo);
                Console.WriteLine(CardNo);
            }
            else{
                Console.WriteLine(str);
            }
        }

        //sortDescending
        public void SortDescending(int num)
        {
            Console.WriteLine(num);
            string str = ""+ num;
            char[] array = new char[str.Length];
            char[] arraydes = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                array[i] = (char)0;
                arraydes[i] = str[i];
            }


            for (int i = 0; i < array.Length; i++)
            {
                int jcount = 0;
                for (int j = 0; j < arraydes.Length; j++)
                {
                   
                    if (array[i] <= arraydes[j])
                    {
                        array[i] 
                            = arraydes[j];
                        jcount = j;

                    }
                }
                arraydes[jcount] = (char)0;
                jcount = 0;
            }
            Console.WriteLine(array);
        }

        //count of positive numbers and the second element is the sum of negative numbers.

        public int[] CountPosSumNeg(int []arr)
        {
            
            int sum = 0,count=0;
            int []sumcount=new int[2];


            for (int i = 0; i < arr.Length; i++)
            {
                
                if (arr[i] > 0)
                {
                    sumcount[0] = ++count;
                }
                if (arr[i] < 0)
                {
                    sum += arr[i];
                    sumcount[1] = sum;
                }
            }
            return sumcount;
        }

    }
        
 }




class assigMain
{
    static void Main(string[] args)
    {
        assign2 q3 = new assign2();

        //Console.WriteLine("enter card number");
        //ConsoleKeyInfo ck = Console.ReadKey(true);
        //q3.MaskedString(ck);
       // string str=Console.ReadLine();
       // q3.Masked(str);

        q3.SortDescending(267423450);

        int[] array = { 1, 5, 56, -3,-10 };




        int[]abc=q3.CountPosSumNeg(array);
        foreach (var item in abc)
            Console.WriteLine(item);
    }
}