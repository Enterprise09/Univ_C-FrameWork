using System;
using static System.Console;

namespace Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            WriteLine($"{kitty.Name} : {kitty.Color}"); //보간법 출력
            WriteLine();

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            WriteLine($"{nero.Name} : {nero.Color}"); //보간법 출력
            WriteLine(nero.Name + " : " + nero.Color);
            WriteLine("{0} : {1}", nero.Name, nero.Color);
        }
    }
}
