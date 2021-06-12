using System;
using static System.Console;

namespace EventExample
{
    public delegate void MyEventHandler();
    class Button
    {
        public event MyEventHandler Push;
        public void OnPush()
        {
            if (Push != null)
            {
                Push();
            }
        }
    }

    class MyEventHandlerClass
    {
        public void MyMethod()
        {
            WriteLine("이벤트 발생 : MyMethod()실행됨");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Button button = new Button();
            MyEventHandlerClass obj = new MyEventHandlerClass();
            button.Push += new MyEventHandler(obj.MyMethod);
            button.OnPush();
        }
    }
}
