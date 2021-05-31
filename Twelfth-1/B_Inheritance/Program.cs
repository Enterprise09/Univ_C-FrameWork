using System;
using System.Collections.Generic;
using static System.Console;

namespace B_Inheritance
{
    class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }
        public void Eat() { WriteLine("Eat"); }
        public void Sleep() { WriteLine("Sleep"); }

    }

    class Dog : Animal
    {
        
        public String Color { get; set; }
        public void Bark() { WriteLine("Bark"); }
    }

    class Cat : Animal
    {
        public void Meow() { WriteLine("cat's Bark"); }
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
                item.Meow();
                WriteLine("Age : " + item.Age);
                WriteLine("---------------------");
            }
        }
    }
}
