using System;
using System.Collections.Generic;

namespace Ninth_project_2
{
    class Program
    {
        static void Main(string[] args)
        {

            /*List<Student> list = new List<Student>();
            list.Add(new Student() { name = "홍길동", grade = 1 });
            list.Add(new Student() { name = "유산슬", grade = 2 });
            list.Add(new Student() { name = "강호동", grade = 3});
            list.Add(new Student() { name = "이하천", grade = 4 });
            list.Add(new Student() { name = "강하늘", grade = 1 });
            list.Add(new Student() { name = "김황야", grade = 2 });
        
            foreach(var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }


            Book book1 = new Book();
            book1.Title = "그냥 태호";
            book1.Content = "5월 시작";
            book1.Writer = "김태호";
            book1.publisher = "GCN";
            book1.published_Date = 20210503;

            Console.WriteLine("제  목 : " + book1.Title);
            Console.WriteLine("내  용 : " + book1.Content);
            Console.WriteLine("저  자 : " + book1.Writer);
            Console.WriteLine("출판사 : " + book1.publisher);
            Console.WriteLine("출판일 : " + book1.published_Date);


            Book book2 = new Book();
            book2.Title = "그냥 태호2";
            book2.Content = "2월 시작";
            book2.Writer = "김태호";
            book2.publisher = "GCN";
            book2.published_Date = 20210505;

            Console.WriteLine("제  목 : " + book2.Title);
            Console.WriteLine("내  용 : " + book2.Content);
            Console.WriteLine("저  자 : " + book2.Writer);
            Console.WriteLine("출판사 : " + book2.publisher);
            Console.WriteLine("출판일 : " + book2.published_Date);

            Product product = new Product();
            product.name = "감자";
            product.price = 2000;

            Console.WriteLine(product.name + " : " + product.price + "원");
            */

            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { name = "고구마", price = 3000 };
            Console.WriteLine(productA.name + " : " + productA.price + "원");
            Console.WriteLine(productB.name + " : " + productB.price + "원");



        }
    }
}
