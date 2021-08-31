using System;
using System.Collections.Generic;
using static System.Console;

namespace A_Inheritance
{
    class Dog
    {
        public int Age { get; set; }
        public String Color { get; set; }
        public Dog() { this.Age = 0; }
        public void Eat() { WriteLine("Eat"); }
        public void Sleep() { WriteLine("Sleep"); }
        public void Bark() { WriteLine("Bark"); }
    }

    class Cat
    {
        public int Age { get; set; }
        public Cat() { this.Age = 0; }

        public void Eat() { WriteLine("cat's Eat"); }
        public void Sleep() { WriteLine("cat's Sleep"); }
        public void Bark() { WriteLine("cat's Bark"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

            WriteLine("Dogs");
            foreach (var item in Dogs)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
                WriteLine("Age : " + item.Age);
                WriteLine("---------------------");
            }

            WriteLine("Cats");
            foreach (var item in Cats)
            {
                item.Eat();
                item.Sleep();
                item.Bark();
                WriteLine("Age : " + item.Age);
                WriteLine("---------------------");
            }
        }
    }
}
