using System;
using static System.Console;

namespace HidingTest
{
    class BaseState
    {
        public virtual void met()
        {
            WriteLine("Parent Met");
        }
    }

    class ChildState : BaseState
    {
        public override void met()
        {
            WriteLine("Child Met");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChildState childState = new ChildState();
            childState.met();
            ((BaseState)childState).met();

        }
    }
}
