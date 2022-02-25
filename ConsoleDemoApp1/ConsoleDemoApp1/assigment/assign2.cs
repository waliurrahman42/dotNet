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
            string str = ""+ num;// converting int in string
            
            char[] arrayofnum = new char[str.Length];
            char[] finalarray = new char[str.Length];

            //inzilizing value in aaray
            for (int i = 0; i < str.Length; i++)
            {
                finalarray[i] = (char)0;//inzilizig value 0
                arrayofnum[i] = str[i];//string to char array
            }

            //finding SortDescending
            for (int i = 0; i < finalarray.Length; i++)
            {
                int jindexcount = 0;
                for (int j = 0; j < arrayofnum.Length; j++)
                {
                   
                    if (finalarray[i] <= arrayofnum[j])
                    {
                        finalarray[i] = arrayofnum[j];
                        jindexcount = j;
                    }
                }
                arrayofnum[jindexcount] = (char)0;//doing value =0 at jindexcount  due to got 1 large num
                jindexcount = 0;
            }
            Console.WriteLine(finalarray);//print 
        }



        //sortDescending2
        public void SortDescending2(int num)
        {
            Console.WriteLine(num);
            string str = "" + num;
           
            char[] arraydes = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                arraydes[i] = str[i];
            }

            for (int i = 0; i < arraydes.Length; i++)
            {
                for (int j = 0; j < arraydes.Length; j++)
                {
                    if (arraydes[i] > arraydes[j])
                    {
                        char temp = arraydes[i];
                        arraydes[i] = arraydes[j];
                        arraydes[j]= temp;
                    }
                }
            }
            Console.WriteLine(arraydes);
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

        public void ReverseString(String str)
        {
            int count = 0, countB = 0;
            char[] temp = new char[str.Length];//for temp
            Char[] chars = new char[str.Length+1];

            for (int i = 0; i < str.Length; i++)
            {
                temp[count++] = str[i];
                if ((str[i] == 32) || (i == str.Length - 1))
                {

                    if (count > 5)
                    {
                        if (i == str.Length - 1)//for last word space
                        { chars[countB++] = (char)32;}
                        
                        int iCount = count;
                        while (iCount != 0)
                        {
                            iCount--;
                            chars[countB++] = temp[iCount];
                        }
                    }
                    else
                    {
                        if (i == str.Length - 1)//for last word space
                        { chars[countB++] = (char)32; }

                        for (int k = 0; k < count; k++)
                        {
                            chars[countB++] = temp[k];
                        }
                    }
                    count = 0;
                }
            }
            //string st = new string(chars);

            foreach (var item in chars)
            {
                Console.Write(item);
            }
        }
        public void ReverseString2(String str)
        {
            string[] arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length >=5)
                {
                    char[] word=arr[i].ToCharArray();

                    int fIndex = 0;
                    int Lindex = word.Length - 1;
                    while(fIndex <= Lindex)
                    {
                        char temp=word[fIndex];
                        word[fIndex]=word[Lindex];  
                        word[Lindex]=temp;
                        fIndex++;
                        Lindex--;
                    }
                    arr[i]=new String(word);
                }

            }
            Console.WriteLine(string.Join(" ",arr));
        }




        //Create a method that takes an array of arrays with numbers. Return a new (single) array with the largest numbers of each.
        public void FindLargestInarray(int[][] arr)
        {
            

            int []largest=new int[arr.Length];
            
            for (int r = 0; r < arr.Length; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    for (int i = 0; i < arr[r].Length; i++)
                    {
                        if ((arr[r][c]) > (arr[r][i]))
                        {
                            //largest[r]=arr[r][c];
                            //arr[r][c] = arr[r][i];
                            //arr[r][i] =largest[r];

                            int temp  = arr[r][c];
                            arr[r][c] = arr[r][i];
                            arr[r][i] = temp; 
                        }
                        
                    }
                   largest[r]=arr[r][0];
                }
                Console.WriteLine();
            }
            //for (int r = 0; r < arr.Length; r++)
            //{
            //    for (int c = 0; c < arr[r].Length; c++)
            //    { 
            //            Console.Write($"{arr[r][c]}\t");

            //    }
            //    Console.WriteLine();
            //}
            foreach (var item in largest)
            {
                Console.Write(item+"," );
            }
        }


    }
    //singlton
    internal class User
    {
        private static User _instance;
        private User() { }

        public static User GetInstance()
        {
            if (_instance == null)
            {
                _instance = new User();
            }
            return _instance;
        }
        public void DisplayMessage()
        {
            Console.WriteLine("SingleTon Program");
        }
    }


   

}




class assigMain
{
    static void Main(string[] args)
    {
        assign2 q3 = new assign2();

        Console.WriteLine("enter card number");
        //ConsoleKeyInfo ck = Console.ReadKey(true);
        //q3.MaskedString(ck);
        string str = Console.ReadLine();
        q3.Masked(str);

        q3.SortDescending2(267423450);

        int[] array = { 1, 5, 56, -3, -10 };




        int[] abc = q3.CountPosSumNeg(array);
        foreach (var item in abc)
            Console.WriteLine(item);

        q3.ReverseString("this is typical sentence ok cooll ok fi");

        int[][] jacked = new int[3][]
                {
                    new int[4]{65,34,5,23},
                    new int[3]{34,54,45},
                    new int[4]{34,54,65,78}
                };

        q3.FindLargestInarray(jacked);
    }
}