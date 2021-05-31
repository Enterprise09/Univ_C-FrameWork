using System;
using static System.Console;

namespace Exception_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            for(int i = 0; i < 3; i++)
            {
                WriteLine(arr[i]);
            }

            WriteLine("종료");
        }
    }
}
