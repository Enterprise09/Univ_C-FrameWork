using System;
using static System.Console;

namespace DelegateExample
{
    //1. create delegate
    public delegate int Calc(int a, int b);

    //2. create class
    class MyClass
    {
        //3. create class method
        public int plus(int a, int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
            //3.create instance
            MyClass myClass = new MyClass();
            Calc calc;

            //4. set function direction
            calc = new Calc(myClass.plus);
            WriteLine(calc(3, 4));
        }
    }
}
