using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.assigment.assig4
{


    public delegate void EventHandler2(String num);

    public class Publisher2
    {
        public event EventHandler2 Length5;
        public event EventHandler2 Length4;
        public event EventHandler2 wrongInput;

        public void Notify(String num)
        {
            if(Length5 != null && Length4 != null)
            {
                if (num.Length == 4)
                {
                    Length4.Invoke(num);
                }
                else if (num.Length == 5)
                {
                    Length4.Invoke(num);
                }
                else
                {
                    wrongInput.Invoke(num);
                }
            }
            else
            {
                Console.WriteLine("length5 or length4 Not subscribe");
            }
        }
    }


    internal class NumTo_Word
    {
        public void FourDigitNumber(string num)
        {
            char[] str=num.ToCharArray();
            string[] ZeroToNine =  {"zero","one","two","three","four","five","six","seven","eight","nine"};
            String[] tenToNineteen = { "ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            String[] twentyToNintey = { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            String[] hundredThosand = { "thousand","hundred" };
            String[] store = new string[num.Length];

            if (num.Length == 4)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == 49) { store[i] = ZeroToNine[1]; }
                    else if (str[i] == 50) { store[i] = ZeroToNine[2]; }
                    else if (str[i] == 51) { store[i] = ZeroToNine[3]; }
                    else if (str[i] == 52) { store[i] = ZeroToNine[4]; }
                    else if (str[i] == 53) { store[i] = ZeroToNine[5]; }
                    else if (str[i] == 54) { store[i] = ZeroToNine[6]; }
                    else if (str[i] == 55) { store[i] = ZeroToNine[7]; }
                    else if (str[i] == 56) { store[i] = ZeroToNine[8]; }
                    else if (str[i] == 57) { store[i] = ZeroToNine[9]; }   
                }
                if (str[2] != 49)
                {
                    if (str[2] == 50) { store[2] = twentyToNintey[0]; }
                    else if (str[2] == 51) { store[2] = twentyToNintey[1]; }
                    else if (str[2] == 52) { store[2] = twentyToNintey[2]; }
                    else if (str[2] == 53) { store[2] = twentyToNintey[3]; }
                    else if (str[2] == 54) { store[2] = twentyToNintey[4]; }
                    else if (str[2] == 55) { store[2] = twentyToNintey[5]; }
                    else if (str[2] == 56) { store[2] = twentyToNintey[6]; }
                    else if (str[2] == 57) { store[2] = twentyToNintey[7]; }
                }
                else if(str[2] == 49) 
                {
                    if (str[3] == 48)      { store[2] = tenToNineteen[0]; store[3] = ""; }
                    else if (str[3] == 49) { store[2] = tenToNineteen[1]; store[3] = ""; }
                    else if (str[3] == 50) { store[2] = tenToNineteen[2]; store[3] = ""; }
                    else if (str[3] == 51) { store[2] = tenToNineteen[3]; store[3] = ""; }
                    else if (str[3] == 52) { store[2] = tenToNineteen[4]; store[3] = ""; }
                    else if (str[3] == 53) { store[2] = tenToNineteen[5]; store[3] = ""; }
                    else if (str[3] == 54) { store[2] = tenToNineteen[6]; store[3] = ""; }
                    else if (str[3] == 55) { store[2] = tenToNineteen[7]; store[3] = ""; }
                    else if (str[3] == 56) { store[2] = tenToNineteen[8]; store[3] = ""; }
                    else if (str[3] == 57) { store[2] = tenToNineteen[9]; store[3] = ""; }
                }
                if (str[0] != 48) { store[0] = store[0] + " " + hundredThosand[0]; }
                if (str[1] != 48) { store[1] = store[1] + " " + hundredThosand[1]; }
                string st = string.Join(" ", store);
                Console.WriteLine(st);
            }
           
        }

        public void WrongInputMethod  (string st)
        {
            Console.WriteLine($"You entered the wrong number.");
        }

        public void FiveDigitNumber(string st)
        {
            char[] str = st.ToCharArray();
            string[] ZeroToNine = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            String[] store = new string[st.Length];


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

            string st1 = string.Join(" ", store);
            Console.WriteLine(st1);
        }

        static void Main(string[] args)
        {
            NumTo_Word num=new NumTo_Word();
            RemoveComonChar re=new RemoveComonChar();
            //do
           // {
                //Console.WriteLine("enter num ");
                //string st = Console.ReadLine();
                //num.NumToWord(st);
                //re.RemoveDublicate("abcdefggbfgdsknjhffvdbjhaskjlfvhbdjshvgdbjfhvbshjhij","shjfsksufhcvysgfwiuelghhcvweiiu");

           // } while (true);


            Publisher2 publisher2 = new Publisher2();
            publisher2.Length5 += new NumTo_Word().FourDigitNumber;
            publisher2.Length4+=new NumTo_Word().FiveDigitNumber;
            publisher2.wrongInput += new NumTo_Word().WrongInputMethod;


            publisher2.Notify("1234");


            Action<string, string> test = RemoveComonChar.RemoveDublicate1;
            test("abcdefggbfgdsknjhffvdbjhaskjlfvhbdjshvgdbjfhvbshjhij","shjfsksufhcvysgfwiuelghhcvweiiu");

        }

    }
}
