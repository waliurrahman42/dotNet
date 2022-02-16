using System;

class hexcode
{


    static void Main(string[] args)
    {

        string st;

        Console.WriteLine("enter string");
        st = Console.ReadLine();
        int flag = 0;

        if (st.Length <= 6 && st[0] == 35)
        {
            for (int i = 1; i < st.Length; i++)
            {
                if ((st[i] >= 48 && st[i] <= 57) || (st[i] >= 65 && st[i] <= 70) || (st[i] >= 97 && st[i] <= 102))
                {
                    flag++;
                }
            }

            if (flag == 5)
            {
                Console.WriteLine("yes this is  hex code");
            }
        }
        else
        {
            Console.WriteLine("no  this is not  hex code");
        }
    }
}