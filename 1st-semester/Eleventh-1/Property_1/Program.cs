using System;
using static System.Console;

namespace Property_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.SetMyField(3);
            WriteLine(myClass.GetMyField());

            /*Read();*/
        }
    }
}
