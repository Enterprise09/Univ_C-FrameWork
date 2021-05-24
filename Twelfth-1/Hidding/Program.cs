using System;
using System.Collections.Generic;
using static System.Console;

namespace Hidding
{
    class Animal
    {
        public void Eat()
        {
            WriteLine("Animals Eat");
        }
    }

    class Dog : Animal
    {
        public void Eat()
        {
            WriteLine("Dog Eat");
        }
    }

    class Cat : Animal
    {
        public void Eat()
        {
            WriteLine("Cat Eat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                WriteLine();
            }
        }
    }
}
