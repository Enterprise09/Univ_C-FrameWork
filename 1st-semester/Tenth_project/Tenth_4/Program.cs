using System;
using static System.Console;

namespace Tenth_4
{
    class Program
    {
        class MyMath
        {
            //static <--> none static
            public int Abs(int x)
            {
                if (x < 0) { return -x; }
                else { return x; }
            }
        }

        static void Main(string[] args)
        {
/*
            WriteLine(MyMath.Abs(52));
            WriteLine(MyMath.Abs(-273));
*/
            MyMath myMath = new MyMath();
            WriteLine(myMath.Abs(52));
            WriteLine(myMath.Abs(-273));

        }
    }
}
