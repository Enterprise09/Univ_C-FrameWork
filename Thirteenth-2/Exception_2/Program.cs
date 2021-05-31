using System;
using static System.Console;

namespace Exception_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] arr = { 1, 2, 3 };
                for (int i = 0; i < 5; i++)
                {
                    WriteLine(arr[i]);
                }
            }
            catch
            {
                WriteLine("종료");
            }

            //시험문제 테스트
            /*for(int k=1; k<=5; k++)
            {
                for(int i=5-k; i>=0; i--)
                {
                    Write(" ");
                }
                for(int j=1; j<=k*2-1; j++)
                {
                    Write("*");
                }
                WriteLine("");
            }*/
        }
    }
}
