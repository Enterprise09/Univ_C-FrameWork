using System;
using System.Collections.Generic;
using static System.Console;

namespace Interface_1
{
    // (1) Create Basic Class & Data 
    class Program
    {
        class Product : IComparable
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                //return this.Price.CompareTo((obj as Product).Price);
                return this.Name.CompareTo((obj as Product).Name);
            }

            public override string ToString()
            {
                return Name + " : " + Price + "won";
            }
        }
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500 },
                new Product() { Name = "사과", Price = 2400 },
                new Product() { Name = "바나나", Price = 1000 },
                new Product() { Name = "배", Price = 3000 }
            };
            list.Sort();

            foreach (var item in list)
            {
                WriteLine(item);
            }
        }
    }
}
