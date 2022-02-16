// C# program to count all duplicates
// from string using hashing
using System;

class GFG
{

    static int NO_OF_CHARS = 256;

    /* Fills count array with
	frequency of characters */
    static void fillCharCounts(String str, int[] count)
    {
        for (int i = 0; i < str.Length; i++)
        {
            count[str[i]]++;
        }
    }

    /* Print duplicates present in
	the passed string */
    static void printDups(String str)
    {

        // Create an array of size 256 and
        // fill count of every character in it
        int[] count = new int[NO_OF_CHARS];
        fillCharCounts(str, count);

        for (int i = 0; i < NO_OF_CHARS; i++)
            if (count[i] > 1)
            {
                Console.WriteLine((char)i + ", " + "count = " + count[i]);
            }
    }

    // Driver Method
    public static void Main()
    {
        String str = "test string";
        printDups(str);
    }
}


