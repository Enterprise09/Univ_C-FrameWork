using System;
using static System.Console;

namespace Property_3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.MyField = 2;
            WriteLine(myClass.MyField);
        }
    }
}
