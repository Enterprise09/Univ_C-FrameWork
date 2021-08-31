using System;
using static System.Console;

namespace Tenth_2
{
    class Program
    {
        class TestA
        {
            public static int Multi(int x, int y)
            {
                return x * y;
            }
        }

        class TestB
        {
            public void Print()
            {
                Console.WriteLine("Calling Print() Method");
            }
        }


        static void Main(string[] args)
        {
            //1. Instanse Method
/*
            TestA testA = new TestA();
            WriteLine(testA.Multi(52, 273));
            WriteLine(testA.Multi(103, 32));
*/

            //Class Method
            WriteLine(TestA.Multi(52, 273));
            WriteLine(TestA.Multi(103, 32));


            TestB testB = new TestB();
            testB.Print();

        }
    }
}
