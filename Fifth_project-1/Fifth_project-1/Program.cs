using System;
using static System.Console;

namespace Fifth_project_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. 중첩조건문
            /*if (DateTime.Now.Hour < 11)
            {
                WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    WriteLine("저녁 먹을 시간입니다.");
                }
            }
            WriteLine();


            //if else if 조건문
            if (DateTime.Now.Hour < 11)
            {
                WriteLine("아침 먹을 시간입니다.");
            }
            else if (DateTime.Now.Hour < 15)
            {
                WriteLine("점심 먹을 시간입니다.");
            }                
            else
            {
                WriteLine("저녁 먹을 시간입니다.");
            }*/


            //논리 연산자와 조건문
            /*double score = 2.0;
            if(4.0 < score && score < 4.5)
            {

            }*/

            /*WriteLine("학점 입력 : ");
            double scoreA = double.Parse(ReadLine());
            if (scoreA == 4.5)
            {
                WriteLine("신");
            }
            else if (4.2 <= scoreA)
            {
                WriteLine("교수님의 사랑");
            }
            else if (3.5 <= scoreA)
            {
                WriteLine("현체제의 수호자");
            }
            else if (2.8 <= scoreA)
            {
                WriteLine("일반인");
            }
            else if(2.3<=scoreA && scoreA < 2.8)
            {
                WriteLine("일탈을 꿈꾸는 소시민");
            }
            else if(1.75 <= scoreA && scoreA < 2.3)
            {
                WriteLine("오락 문화의 선구자");
            }
            else if(1.0 <= scoreA && scoreA < 1.74)
            {
                WriteLine("불가촉 천민");
            }
            else if(0.5 <= scoreA && scoreA < 0.9)
            {
                WriteLine("자벌레");
            }
            else if(0<= scoreA && scoreA < 0.4)
            {
                WriteLine("플랑크톤");
            }
            else
            {
                WriteLine("시대를 앞서가는 형명의 씨앗");
            }*/


                //switch조건문

                //break 키워드를 사용하지 않는 switch 조건문
                /* Write("이번 달은 몇 월인가요? : ");
                 int input = int.Parse(ReadLine());
                 switch (input)
                 {
                     case 12:
                     case1:
                     case2:
                         WriteLine("겨울입니다.");
                         break;
                     case 3:
                     case 4:
                     case 5:
                         WriteLine("봄입니다.");
                         break;
                     case 6:
                     case 7:
                     case 8:
                         WriteLine("여름입니다.");
                         break;
                     default:
                         WriteLine("다른 행성입니다.");
                         break;
                 }*/


                //3항 연산자
                /*WriteLine("숫자 입력 : ");
                int number = int.Parse(ReadLine());
                WriteLine(number % 2 == 0 ? true : false);
                WriteLine(number % 2 == 0 ? "짝수" : "홀수");


                WriteLine(number > 0 ? "자연수입니다." : "자연수가 아닙니다.");*/


                //키입력 구분
                /*ConsoleKeyInfo info = ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        WriteLine("아래쪽으로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        WriteLine("왼쪽으로 이동");
                        break;
                    default:
                        WriteLine("다른 키를 눌렀습니다.");
                        break;
                }*/


                //7번문제
                /*Write("태어난 년도 : ");
                int birth = int.Parse(ReadLine());

                switch (birth % 12)
                {
                    case 0:
                        WriteLine("원숭이 띠입니다.");
                        break;

                    default:
                        break;
                }*/


                //8번
                /*Write("현재가 몇월인지 입력해주세요 : ");
                int year = int.Parse(ReadLine());

                if(3 <= year && year <= 5)
                {
                    WriteLine("봄입니다.");
                }
                else if(6 <= year && year <= 8)
                {
                    WriteLine("여름입니다.");
                }
                else if(9 <= year && year <= 11)
                {
                    WriteLine("가을입니다.");
                }
                else
                {
                    WriteLine("겨울입니다.");
                }*/


                //반복문
                //반복문을 사용한 반복
                /*for(int i = 0; i<5; i++)
                {
                    WriteLine("출력");
                }*/


                //기본적인 배열 생성 방법
                /*int[] intArray = { 52, 273, 32, 65 };
                long[] longArray = { 52, 273, 32, 65 };
                float[] floatArr = { 1.0F, 2.0F, 3.0F };
                double[] doubleArr = { 1.0, 2.0, 3.0 };
                char[] charArr = { '가', '나', '다' };
                string[] strArr = { "안녕", "홍길동", "Hello" };

                WriteLine(intArray[0]);
                WriteLine(longArray[0]);
                WriteLine(floatArr[0]);
                WriteLine(doubleArr[0]);
                WriteLine(charArr[0]);
                WriteLine(strArr[0]);
                WriteLine(intArray.Length);*/


                //원한은 크기의 배열 생성 방법
                int[] intArr = new int[100];
            WriteLine(intArr[0]);
            WriteLine(intArr[99]);

            char[] charArr = new char[100];
            WriteLine(charArr[0]);
            WriteLine(charArr[99]);

        }
    }
}
