using System;
using static System.Console;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            BoxA boxA = new BoxA(10, 10);
            WriteLine(boxA.Area());
        }
    }
}
