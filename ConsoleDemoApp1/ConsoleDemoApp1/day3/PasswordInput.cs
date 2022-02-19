using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day3
{
    internal class PasswordInput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Password: ");
            ConsoleKeyInfo ck = Console.ReadKey(true);
            string password = "";
            while (ck.Key != ConsoleKey.Enter)
            {
                Console.Write("*");
                password += ck.KeyChar;
                ck = Console.ReadKey(true);
            }
            Console.WriteLine("\nEntered Password is: " + password);

        }
    }
}
