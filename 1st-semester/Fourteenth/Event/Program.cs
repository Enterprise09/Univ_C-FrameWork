using System;
using static System.Console;

namespace Event
{
    delegate void EventHandler(string message);     //delegate

    class MyNotifier{
        public event EventHandler SomethingHappend;     //대리자의 인스턴스 생성

        public void DoSomething(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)
            {
                SomethingHappend(String.Format("{0} : 짝", number));
            }
        }
    }

    class Program
    {
        static public void MyHandler(string message)
        {
            WriteLine(message);
        }
        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappend += new EventHandler(MyHandler);
            for (int i = 1; i < 30; i++)
            {
                notifier.DoSomething(i);
            }
        }
    }
}
