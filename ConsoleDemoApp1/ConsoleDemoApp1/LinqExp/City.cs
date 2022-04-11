using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.LinqExp
{
    internal class City
    {
        public int Id { get; set; }
        public int CityStateId { get; set; }
        public string CityName { get; set; }
    }
}


namespace ConsoleDemoApp1.LinqExp
{
    internal class StateCity
    {




        static void Main(string[] args)
        {

            IList<City> cities = new List<City>()
            {
               new City(){Id=1,CityStateId=1,CityName="Agra"},
               new City(){Id=2,CityStateId=1,CityName="Lucknow"},
               new City(){Id=3,CityStateId=2,CityName="Bhopal"},
               new City(){Id=4,CityStateId=2,CityName="satna"},
               new City(){Id=5,CityStateId=3,CityName="patna"},
               new City(){Id=6,CityStateId=3,CityName="gaya"},
            };

            IList<State> states = new List<State>()
            {
                new State(){Id=1,StateName="UP"},
                new State(){Id=2,StateName="MP"},
                new State(){Id=3,StateName="Bihar"}
            };


            var city= from s in states
                      join c in cities
                      on s.Id equals c.CityStateId
                      select new {c.Id,c.CityName,SID=s.Id ,s.StateName};
                                                  //alias

            Console.WriteLine("city data");
            foreach (var c in city)
            {
                Console.WriteLine($"{c.Id}\t{c.CityName}\t{c.SID}\t{c.StateName}");
            }










            //var city = from c in cities
            //           select c;
            // var city = from c in cities
            //          where c.CityStateId==3
            //          select c;



            //immediate execution
            // var city = cities.Where(c=> c.CityStateId==3).ToList();

            //var city = from c in cities
            //           where c.CityStateId == 3
            //           select new { c.Id, c.CityName };



            // var city = cities.Skip(1);

            // var city = cities.OrderBy(c => c.Id)
            //     .SkipWhile(c => c.Id <= 1);

            //var city = cities.Take(1);
            // var city = cities.TakeWhile(c=>c.Id<8);


            /* var city = cities.FirstOrDefault(c=>c.Id<8);
             if(city != null) {
                 Console.WriteLine($"Id: {city.Id}\tCityStateId: {city.CityStateId}\tCityName: {city.CityName}");
             }*/





            /* Console.WriteLine("cities are");
             foreach (var c in city)
             {
                 Console.WriteLine($"Id: {c.Id}\tCityStateId: {c.CityStateId}\tCityName: {c.CityName}");
             }
 */

/*
            var stategroup = from c in cities
                             group c by c.CityStateId;

            foreach (var state in stategroup)
            {
                Console.WriteLine(state.Key + "=>");
                foreach (City c in state)
                {
                    Console.WriteLine(c.Id + "=>" + c.CityStateId + "=>" + c.CityName);
                }
            }*/










        }
        



    }
}