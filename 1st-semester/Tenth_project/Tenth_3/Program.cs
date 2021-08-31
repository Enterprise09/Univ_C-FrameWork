using System;
using static System.Console;

namespace Tenth_3
{
    class Program
    {
        class TestA
        {
            public static int Sum(int min, int max)
            {
                int output = 0;
                for (int i = min; i <= max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        class TestB
        {
            public static long Multifly(long min, long max)
            {
                long output = 1;
                for (long i = min; i <= max; i++) {
                    output *= i;
                }
                return output;
            }
            

        }
       
        static void Main(string[] args)
        {
            /*
                        TestA testa = new TestA();
                        WriteLine(testa.Sum(1, 100));

                        TestB testb = new TestB();
                        WriteLine(testb.Multifly(1, 20));
            */

            WriteLine(TestA.Sum(1, 100));
            WriteLine(TestB.Multifly(1, 20));
        }
    }
}
