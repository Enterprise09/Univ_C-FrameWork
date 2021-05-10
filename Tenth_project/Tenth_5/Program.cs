using System;
using static System.Console;

namespace Tenth_5
{
    class Program
    {
        class MyMath
        {
            //Method Overloading
            public static int Abs(int x)
            {
                if (x < 0) { return -x; }
                else { return x; }
            }

            public static double Abs(double x)
            {
                if (x < 0) { return -x; }
                else { return x; }
            }

            public static long Abs(long x)
            {
                if (x < 0) { return -x; }
                else { return x; }
            }
        }

        static void Main(string[] args)
        {
            //int
            WriteLine(MyMath.Abs(52));
            WriteLine(MyMath.Abs(-273));

            //double
            WriteLine(MyMath.Abs(52.273));
            WriteLine(MyMath.Abs(-30.103));

            //long
            WriteLine(MyMath.Abs(21474836470));
            WriteLine(MyMath.Abs(-21474836470));

        }
    }
}
