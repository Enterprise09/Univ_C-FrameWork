using System;
using static System.Console;

namespace Interface_2
{
    class Program
    {
        class TestClass : IBasic    // (2)Interface
        {
            // (3)Implement Interface
            public int TestProperty { 
                get => throw new NotImplementedException(); 
                set => throw new NotImplementedException();
            }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }


        static void Main(string[] args)
        {
            // (4)다형성 구현
            IBasic basic = new TestClass();
            
        }
    }
}
