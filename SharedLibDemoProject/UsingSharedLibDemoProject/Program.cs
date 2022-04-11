 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLibDemoProject;


namespace UsingSharedLibDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SharedLibrary sharedLibrary = new SharedLibrary();
            sharedLibrary.Display();
        }



    }
}
