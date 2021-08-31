using System;
using static System.Console;

namespace Property_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyField = 3;
            WriteLine(myClass.MyField);
        }
    }
}
