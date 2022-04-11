using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleDemoApp1.LinqExp
{
    internal class HashTableDemo
    {

        static void Main(string[] args)
        {
            Hashtable person=new Hashtable();
            person.Add("rahul",56878874656);
            person.Add("sajid",6565874668);
            person.Add("adeel",56534274645);
            person.Add("naiyer",2358687465);
            person.Add("abdullah",4688674262);
            person.Add("saddam",2462642625);


            Console.WriteLine("dictionaryEntry");
            foreach (DictionaryEntry p in person)
            {
                Console.WriteLine(person.Key+"=>"+person.value);
            }

            
        }
    }
}
