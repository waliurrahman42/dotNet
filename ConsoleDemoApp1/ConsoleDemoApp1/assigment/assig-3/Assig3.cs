using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.assigment.assig_3
{
    internal class Assig3
    {

        //Create a method that takes the width, height and character and
        //returns a picture frame as an array of strings(string[] ).

        public void Get_Frame(int b, int l, string str)
        {

            String[,] arr = new String[l, b];
            if ((str[0] != 48) && (l > 3) && (b > 3))
            {   for (int r = 0; r <= arr.GetUpperBound(0); r++)
                {
                    for (int c = 0; c <= arr.GetUpperBound(1); c++)
                    {
                        if (c == 0)
                        {
                            arr[r, c] = str;
                        }
                        else if ((r == arr.GetUpperBound(0)) || r == 0)
                        {
                            arr[r, c] = str;
                        }
                        else if (c == arr.GetUpperBound(1))
                        {
                            arr[r, c] = str;
                        }
                        else
                        {
                           
                            arr[r, c] = " ";
                        }
                    }
                }
            }
            else
            {
                arr[0, 0] = "invalid";
            }
            for (int r = 0; r <= arr.GetUpperBound(0); r++)
            {
                for (int c = 0; c <= arr.GetUpperBound(1); c++)
                {
                    Console.Write($"{arr[r, c]}");    
                }
                Console.WriteLine();
            }
        }



        //Generate your own method to satisfy the relationship between the inputs and outputs.
        //Your task is to create a method that, when fed the inputs below, produce the sample outputs shown.
      
        public void Q1(String str)
        {
            char[] array=str.ToCharArray();
          

            for (int i = 0; i < array.Length-1; i+=2)
            {

                int num = (array[i + 1])-'0';
                for (int j = 0; j < num; j++)
                {
                    Console.Write(array[i]);
                }
                
            }
        }


        //ToCamelCase
        public void Q3ToCamelCase(String str)
        {
            string[] array=str.Split('_');
            for (int i = 0;i < array.Length-1  ;i++)
            {
                char [] word= array[i+1].ToCharArray();
                word[0] -=(char)32;
                array[i+1] = new String(word);
            }
            Console.WriteLine(string.Join("", array));  
        }


        //ToSnakeCase
        public void Q3ToSnakeCase(String str)
        {

            string st = " ";
           
            for (int i = 0; i < str.Length ; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    st += '_';
                }
                st += str[i];
            }
            
            string[] array = st.Split('_');
            
            for (int i = 0; i < array.Length - 1; i++)
            {
                char[] word = array[i + 1].ToCharArray();
                word[0]+=(char)32;
                array[i+1] = new String(word);
            }
            Console.WriteLine(string.Join("_",array));
        }


        //IsMatch
        public void Q4IsMatch(String str)
        {
            bool result = Regex.IsMatch(str, "\\d");
            Console.WriteLine(result);
        }
        //Split
        public void Q4Split(String str)
        {
            string[] splitdata = Regex.Split(str, @"\d{2,}");
            Console.WriteLine("split Data:");
            foreach (var data in splitdata)
            {
                Console.WriteLine(data);
            }

        }
        //Match
        public void Q4Match(String str)
        {
            Match match = Regex.Match(str, "\\d{2,}");
            Console.WriteLine(match.Success);
            Console.WriteLine(match.Value);
            Console.WriteLine(match.Length);
            match = match.NextMatch();
            Console.WriteLine(match.Value);
            match = match.NextMatch();
            Console.WriteLine(match.Value);
        }
        //Maches
        public void Q4Maches(String str)
        {
            MatchCollection matches = Regex.Matches(str, @"\d{2,}");
            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value);
            }
        }
        //Replace
        public void Q4Replace(String str)
        {
            string newstr = Regex.Replace(str, @"\d{2,}", "_");
            Console.WriteLine(newstr);
        }

        
        //program to demonstrate useful methods  of Math class
        public void MathClass()
        {
            Math.Round(9.99);
            Math.Abs(-4.7);
            Math.Sqrt(64);
            Math.Min(5, 10);
            Math.Max(5, 10);
        }

    }

    //Define a Class to implement indexer for a 2-D Array.

    class Student
    {
        int[,] id;

        public Student(int size=5)
        {
            id = new int[size,size];
        }


        public int this[int i,int j]
        {
            get
            {
                return id[i,j];
            }
            set
            {
                id[i,j] = value;
            }
        }

        public int ArrayLength
        {
            get => id.GetUpperBound(0);
        }

    }












    class Assig3Test
    {
        static void Main(string[] args)
        {
            Assig3 assig3 = new Assig3();
            
            assig3.Get_Frame(4,4,"1");
            
            assig3.MathClass();

            assig3.Q1("A1B2C3W1w6");
            assig3.Q3ToCamelCase("wali_rahman");
            assig3.Q3ToSnakeCase("waliRahmanDarood");
            assig3.Q4IsMatch("wajcbd2342kjvdsjkbvfhlsa43780236vnjskdj");
            assig3.Q4Split("wajcbd2342kjvdsjkbvfhlsa43780236vnjskdj");
            assig3.Q4Match("wajcbd2342kjvdsjkbvfhlsa43780236vnjskdj");
            assig3.Q4Maches("wajcbd2342kjvdsjkbvfhlsa43780236vnjskdj");
            assig3.Q4Replace("wajcbd2342kjvdsjkbvfhlsa43780236vnjskdj");

            Student i = new Student();
            //1st row
            i[0, 0] = 1;
            i[0, 1] = 2;
            i[0, 2] = 3;
            i[0, 3] = 4;
            i[0, 4] = 5;

            //2nd row
            i[1, 0] = 6;
            i[1, 1] = 7;
            i[1, 2] = 8;
            i[1, 3] = 9;
            i[1, 4] = 10;

            //3rd row

            i[2, 0] = 11;
            i[2, 1] = 12;
            i[2, 2] = 13;
            i[2, 3] = 14;
            i[2, 4] = 15;

            for (int r = 0; r <= i.ArrayLength; r++)
            {
                for (int c = 0; c <= i.ArrayLength; c++)
                {
                    Console.Write($"{i[r, c]}\t");
                }
                Console.WriteLine();
            }





        }
    }
}
