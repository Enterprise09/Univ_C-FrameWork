using System;
using static System.Console;

namespace ShadowAndHide
{
    public class Parent
    {
        public int variable = 273;

        public Parent()
        {
            WriteLine("Parent ");
        }

        public void Method()
        {
            WriteLine("Parent Method");
        }
    }

    public class Child : Parent
    {
        public int variable = 2;

        public Child() : base()
        {
            WriteLine("Child");
        }

        public void Method()
        {
            WriteLine("Child Method");
        }
    }
    class Program
    {
        public static int number = 10;
        static void Main(string[] args)
        {
            int number = 20;
            WriteLine(number);
            WriteLine();

            Child childA = new Child();
            WriteLine(childA.variable);
            childA.Method();
            WriteLine();

            Child childB = new Child();
            WriteLine(((Parent)childB).variable);
            ((Parent)childB).Method();
            
        }
    }
}
