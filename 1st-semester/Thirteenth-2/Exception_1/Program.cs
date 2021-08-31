using System;
using static System.Console;

namespace Exception_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] array = { "가", "나" };
            WriteLine("숫자를 입력해주세요 : ");
            int input = int.Parse(ReadLine());
            WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");*/

            //Basic Exception Process
            string[] array = { "가", "나" };
            WriteLine("숫자를 입력해주세요 : ");
            int input = int.Parse(ReadLine());
            if (input < array.Length)
            {
                WriteLine("입력한 위치의 값은 '" + array[input] + "'입니다.");
            }
            else
            {
                WriteLine("인덱스 범위를 넘었습니다.");
            }

        }
    }
}
