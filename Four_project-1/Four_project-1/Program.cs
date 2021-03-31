using System;
using static System.Console;

namespace Four_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //입력
            /*WriteLine(" * 저번시간 내용 - 입력 : ");
            string input = Console.ReadLine();
            Console.WriteLine("Input : " + input);
            Console.WriteLine();
            WriteLine("*******************************************");*/


            //자료형 변환 : 한 자료형을 다른 자료형으로 바꾸는 것
            //1. 강제 자료형 변환
            /*long longNumber = 2147483647L + 2147483647L;
            int intNumber = longNumber;
            WriteLine(intNumber);*/

            //강제 자료형 변환 : (변환하고자하는 자료형)변환되는 자료;
            //var  반드시 지역변수 -> 전역변수 안됨
            //     반드시 선언과 동시에 초기화
            /*var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            WriteLine(a);
            WriteLine(b);
            WriteLine(c);*/


            //데이터 손실 발생 : long -> int 변환시 
            //데이터 손실 즉, 데이터가 손상되어 의도하지 않은 값이 나옴
            /*long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;
            WriteLine(intNumber);*/


            /*long longNumber = 52273;
            int intNumber = (int)longNumber;
            WriteLine(intNumber);*/


            //2. 자동 자료형 변환
            //데이터 손상    long -> int
            //               double -> int      소수점밑에 숫자는 전부 짤림, 반올림도 안됨
            /*double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            WriteLine(doubleToInt);*/


            //3. 다른 자료형을 숫자로 변환하는 메서드 : .Parse()
            /*WriteLine(int.Parse("52"));
            WriteLine(long.Parse("273"));
            WriteLine(float.Parse("52.273"));
            WriteLine(double.Parse("103.32"));

            WriteLine(int.Parse("52").GetType());
            WriteLine(long.Parse("273").GetType());
            WriteLine(float.Parse("52.273").GetType());
            WriteLine(double.Parse("103.32").GetType());*/


            //예외발생 : 숫자로 변환할 수 없는 문자열을 변환하는 경우
            /*WriteLine(int.Parse("52.273"));
            WriteLine(int.Parse("abc"));*/


            //대소문자를 구분
            //4. 다른 자료형을 문자열로 변환
            /*WriteLine((52).ToString());         //GetType()써도 String형으로 표현됨
            WriteLine((52.273).ToString());
            WriteLine(('a').ToString());
            WriteLine((true).ToString());
            WriteLine((false).ToString());*/

            //소수점 제거
            /*double number = 52.273103;
            //ToString() 은 표현하는 숫자를 반올림하여 표현함 _ double, float -> int 하면 소수점 밑이 모두 잘림
            WriteLine(number.ToString("0.0"));      //문자열로 표현하되 소수점 첫째자리까지 표시
            WriteLine(number.ToString("0.00"));     //소수점 둘째자리까지 표시
            WriteLine(number.ToString("0.000"));    //소수점 셋째자리까지 표시*/

            //숫자와 문자열 덧셈 : 숫자가 자동으로 문자열로 변환 > 숫자가 문자열로 변환되어 그냥 이어붙여짐
            /*WriteLine(52 + 273);        //숫자
            WriteLine("52" + 273);      //52273 >> 문자열로 표현됨
            WriteLine(52 + "273");      //52273 >> 문자열로 표현됨  
            WriteLine("52" + "273");    //52273 >> 문자열로 표현됨*/

            //간단한 문자열 변환 방법
            /*int number = 52273;
            string outputA = number + "";
            WriteLine(outputA);     //ouputA.GetType은 문자열(String)형으로 나옴
            WriteLine(outputA.GetType());*/

            //문자도 문자열을 연결해주면 문자열(String)형으로 변환된다.
            /*char ch = 'a';
            //string ouputB = ch;     //문자는 문자열로 변환이 불가능하다.
            string outputB = ch + "";     //따라서 문자를 문자열로 변환하려면 빈 문자열을 문자에 더해주면 된다.
            WriteLine(outputB);
            WriteLine(outputB.GetType());*/

            //다른 자료형을 bool로 표현
            //문자열을 bool로 변환
            /*WriteLine(bool.Parse("True"));
            WriteLine(bool.Parse("true"));
            WriteLine(bool.Parse("False"));
            WriteLine(bool.Parse("false"));

            WriteLine(bool.Parse("True").GetType());
            WriteLine(bool.Parse("true").GetType());
            WriteLine(bool.Parse("False").GetType());
            WriteLine(bool.Parse("false").GetType());*/


            /*WriteLine("kg단위를 입력세요 : ");
            double kg = double.Parse(ReadLine());
            double result = kg * 2.20462262;
            WriteLine(result + "pound");*/

            /*WriteLine("원의 반지름을 입력하세요 : ");
            double r = double.Parse(ReadLine());
            double l = r * Math.PI * 2;
            double s = r * r * Math.PI;
            WriteLine("원의 넓이 : " + s);
            WriteLine("원의 둘레 : " + l);*/

            //조건문
            WriteLine("숫자 입력 : ");
            int input = int.Parse(ReadLine());

            /*if(input % 2 == 0)
            {
                WriteLine("짝수입니다.");
            }
            
            //if조건문
            *//*if(input % 2 == 1)
            {
                WriteLine("홀수입니다.");
            }*//*

            //if-else조건문
            else
            {
                WriteLine("홀수입니다.");
            }*/

            //switch조건문
            switch (input % 2)
            {
                case 0:
                    WriteLine("짝수입니다.");
                    break;

                case 1:
                    WriteLine("홀수입니다.");
                    break;
            }
        }
    }
}
