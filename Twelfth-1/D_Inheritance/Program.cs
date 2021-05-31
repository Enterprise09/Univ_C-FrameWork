using System;
using static System.Console;

namespace D_Inheritance
{
    public class Parent
    {
        public Parent()
        {
            WriteLine("Parent ");
        }
    }

    public class Child : Parent
    {
        public Child() : base()
        {
            WriteLine("Child");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
        }
    }
}
