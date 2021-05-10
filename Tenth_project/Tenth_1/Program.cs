using System;

namespace Tenth_1
{
    class Program
    {
        class Test
        {
            public static int Power(int x)
            {
                return x * x;
            }
        }

        static void Main(string[] args)
        {
            /*
                        Test test = new Test();
                        Console.WriteLine(test.Power(3));
                        Console.WriteLine(test.Power(10));
            */


            Console.WriteLine(Test.Power(10));
            Console.WriteLine(Test.Power(20));
        }
    }
}
