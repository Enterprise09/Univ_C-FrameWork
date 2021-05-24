using System;
using System.Collections.Generic;
using static System.Console;

namespace C_Inheritance
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
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Dog(), new Cat(),
                new Cat(), new Cat(), new Dog(), new Dog()
            };

            List<Animal> Cats = new List<Animal>() { new Cat(), new Cat(), new Cat() };


            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();               

                /*if (item is Dog)
                {
                    ((Dog)item).Bark();
                }
                if(item is Cat)
                {
                    ((Cat)item).Meow();
                }*/

                //Using as Keyword
                if(item is Dog) { (item as Dog).Bark(); }
                if(item is Cat) { (item as Cat).Meow(); }

                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if(cat != null) { cat.Meow(); }
            }
        }
    }
}
