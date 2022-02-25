using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp1.day7
{
    class Product :IComparable<Product>
    {
        int _Pid;
        string _Name;
        float _Price;
        string _Brand;


        public int PId { get => _Pid; set => _Pid = value; }
        public string Name { get => _Name; set => _Name = value; }
        public float Price { get => _Price; set => _Price = value; }
        public string Brand { get => _Brand; set => _Brand = value; }



        public int CompareTo(Product obj)
        {
            return this._Pid.CompareTo(obj._Pid);
            return obj._Pid.CompareTo(this._Pid);
        }




        public override string ToString()
        {
            return $"ID:{_Pid}\tname:{_Name}\tprice:{_Price}\tbrand:{_Brand}";
        }



    }



    class SortByNameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }



    class SortByPriceComparer : IComparer
    {
        bool sortBy;






        public int Compare(dynamic x, dynamic y)
        {
            return x.Price.CompareTo(y.Price);
        }
    }








    internal class ArrayDemo
    {
        static void Main(string[] args)
        {
            Product [] products = new Product[]
                                    {
                                        new Product() {PId=101 ,Name ="soap",Brand="dettol",Price=25.0f},
                                        new Product() {PId=107 ,Name ="laptop",Brand="msi",Price=255555.0f},
                                        new Product() {PId=102 ,Name ="mobile",Brand="mi",Price=25344.0f},
                                        new Product() {PId=109 ,Name ="headphone",Brand="boat",Price=25.0f},
                                        new Product() {PId=1011 ,Name ="led bulb",Brand="syska",Price=25.0f},
                                    };

            Console.WriteLine( "product details");
            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }


            Array.Sort(products);//will sort data by id

            Console.WriteLine("Sorted product details:");
            foreach(Product item in products)
            {
                Console.WriteLine(item);
            }

            Array.Sort(products, new SortByNameComparer());//sort by name


            Console.WriteLine("Sorted product  details by name :");
            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }





            Array.Sort(products,new SortByPriceComparer());//sort by price

            Console.WriteLine("Sorted product details by price:");
            foreach (Product item in products)
            {
                Console.WriteLine(item);
            }
        }
    }
}
