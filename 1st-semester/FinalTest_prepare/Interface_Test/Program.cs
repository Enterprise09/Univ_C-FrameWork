using System;
using System.Collections.Generic;
using static System.Console;

namespace Interface_Test
{
    class Program
    {
        class Product : IComparable
        {
            public String Name { get; set; }
            public int Price { get; set; }

            public int CompareTo(object obj)
            {
                return Price.CompareTo((obj as Product).Price);     //가격 기준으로 내림차순 정렬
                //return Name.CompareTo((obj as Product).Name);     //이름 기준으로 내림차순 정렬
            }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product(){Name="고구마", Price=1500},
                new Product(){Name="사과", Price=2400},
                new Product(){Name="바나나", Price=1000},
                new Product(){Name="배", Price=3000},
            };
            list.Sort();
            foreach (var item in list)
            {
                WriteLine(item);
            }
        }
    }
}
