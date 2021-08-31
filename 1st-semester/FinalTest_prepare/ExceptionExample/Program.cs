using System;
using static System.Console;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                WriteLine("숫자 입력 : ");
                string input = ReadLine();

                int index = int.Parse(input);
                WriteLine("입력 숫자 : " + index);
            }
            catch (Exception e)
            {
                WriteLine($"예외가 발생했습니다. : {e.Message}");
            }
            finally
            {
                WriteLine("프로그램 종료");
            }


        }
    }
}
