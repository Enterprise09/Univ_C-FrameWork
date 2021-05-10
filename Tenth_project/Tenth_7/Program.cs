using System;
using static System.Console;

namespace Tenth_7
{
    class Program
    {
        class Product
        {
            public static int counter = 0;
            public int id;
            public string name;
            public int price;

            public Product(string name, int price)
            {
                Product.counter = counter + 1;
                this.id = counter;
                this.name = name;
                this.price = price;
            }
        }
        static void Main(string[] args)
        {
            Product product1 = new Product("감  자", 5000);
            Product product2 = new Product("고구마", 6000);
            Product product3 = new Product("당  근", 2000);
            Product product4 = new Product("오  이", 3000);
            Product product5 = new Product("고  추", 1500);

            WriteLine(product1.id + " : " + product1.name + " : " + product1.price + "원");
            WriteLine(product2.id + " : " + product2.name + " : " + product2.price + "원");
            WriteLine(product3.id + " : " + product3.name + " : " + product3.price + "원");
            WriteLine(product4.id + " : " + product4.name + " : " + product4.price + "원");
            WriteLine(product5.id + " : " + product5.name + " : " + product5.price + "원");
            WriteLine(Product.counter + "개 생성되었습니다.");
        }
    }
}
