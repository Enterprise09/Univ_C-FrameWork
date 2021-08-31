using System;
using System.Collections.Generic;
using static System.Console;

namespace HidingTest
{
    class Animal
    {
        public virtual void Eat()
        {
            WriteLine("냠냠 먹습니다.");
        }
    }

    class Dog : Animal
    {
        public new void Eat()
        {
            WriteLine("강아지 사료를 먹습니다.");
        }
    }

    class Cat : Animal
    {
        public override void Eat()
        {
            WriteLine("고양이 사료를 먹습니다.");
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
            }

        }
    }
}
