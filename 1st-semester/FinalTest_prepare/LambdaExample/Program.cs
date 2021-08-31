using System;
using static System.Console;

namespace LambdaExample
{
    
    class Program
    {
        delegate int Calc(int a, int b);
        delegate void Dosomething();
        static void Main(string[] args)
        {
            Calc calc = (a, b) => a + b;
            Dosomething dosomething = () => {
                WriteLine("Dosomthing");
            };
            WriteLine(calc(3, 4));
            dosomething();
        }
    }
}
