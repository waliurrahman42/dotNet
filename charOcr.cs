using System;


class CharOccur
{

    static void Main()
    {
        Console.WriteLine("enter a string");
        //string st = Console.ReadLine();
        string st = "Createamethodthattakesastringandreturnsthenumberof";
        string alph = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        String contstr;
        int count = 0;
        for (int i = 0; i <= alph.Length; i++)
        {
            for (int j = 0; j <= st.Length; j++)
            {
                if (alph[i] == st[j])
                {
                    count++;
                }
            }
            contstr = alph[i] + "=" + count;
            Console.WriteLine(contstr);
            contstr = "";
            count = 0;
        }
    }

}