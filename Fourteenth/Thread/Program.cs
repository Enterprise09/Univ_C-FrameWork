using System;
using static System.Console;

namespace Thread
{
    class Program
    {
        static void ThreadBody()
        {
            for(int i = 0; i<=15; i++)
            {
                WriteLine(DateTime.Now.Second + " : " + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
