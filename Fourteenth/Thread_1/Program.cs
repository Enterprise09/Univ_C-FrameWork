using System;
using System.Threading;
using static System.Console;

namespace Thread_1
{
    class Program
    {
        static void ThreadBody()
        {
            for (int i = 0; i <= 15; i++)
            {
                WriteLine(DateTime.Now.Second + " : " + i);
                Thread.Sleep(1000);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(ThreadBody);
            Thread t = new Thread(ts);

            WriteLine("*** Start of Main");
            t.Start();
            WriteLine("*** End of Main");
        }
    }
}
