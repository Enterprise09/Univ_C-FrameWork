using System;
using static System.Console;

namespace IDisposableTest
{
    class Program
    {
        class Durmmy : IDisposable
        {
            public void Dispose()
            {
                WriteLine("Dispose()메소드 호출됨");
            }
        }

        static void Main(string[] args)
        {
            Durmmy durmmy = new Durmmy();
            durmmy.Dispose();

        }
    }
}
