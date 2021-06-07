using System;
using static System.Console;

namespace Lambda
{
    class Program
    {
        delegate int Calculate(int a, int b);
        static void Main(string[] args)
        {
            /*Calculate calc = (int a, int b) => a + b;*/
            Calculate calc = (a, b) => a + b;   //형식유추형 Lambda
            WriteLine($"{3} + {4} : {calc(3, 4)}");
        }
    }
}
