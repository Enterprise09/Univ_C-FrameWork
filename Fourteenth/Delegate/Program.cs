using System;
using static System.Console;

namespace Delegate
{
    delegate int MyDelegate(int a, int b);      //Delegate
    class Calculator{
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            /*대리자의 인스턴스를 만들 때도 new 연산자 필요
            대리자를 메서드 호출하듯 사용하면, 참조하고 있는 메서드가 실행됨*/
            Callback = new MyDelegate(Calc.Plus);
            WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calc.Minus);
            WriteLine(Callback(7, 5));
        }
    }
}
