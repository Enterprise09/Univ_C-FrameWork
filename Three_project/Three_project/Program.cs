using System;
using static System.Console;
namespace Three_project
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. sizeof()연산자와 char 자료형의 크기
            WriteLine("******************************************");
            WriteLine("");
            WriteLine("1. sizeof()연산자와 char자료형의 크기");
            WriteLine("");
            WriteLine("int : " + sizeof(int));
            WriteLine("long : " + sizeof(long));
            WriteLine("float : " + sizeof(float));
            WriteLine("double : " + sizeof(double));
            WriteLine("char : " + sizeof(char));
            WriteLine("");
            WriteLine("******************************************");

            WriteLine("");

            //2. 문자열 자료형           
            WriteLine("2. 문자열 자료형");
            WriteLine("");
            string msg = "안녕하세요";

            WriteLine(msg + "!");
            WriteLine(msg[0]);
            WriteLine(msg[1]);
            WriteLine(msg[2]);

            WriteLine("");

          /*int output = 0;
            output += 52;
            output += 273;
            output += 103;

            WriteLine(output);*/


            //6. 증감 연산자 >> 시험문제 !
            WriteLine("******************************************");
            WriteLine("");
            WriteLine("6. 증감 연산자 >> 시험문제");
            WriteLine("");

            int number = 10;
            number++;
            WriteLine(number);  //10
            number--;
            WriteLine(number);  //11

            int number2 = 20;
            WriteLine(number2);     //20
            WriteLine(number2++);   //20
            WriteLine(number2--);   //21
            WriteLine(number2);     //20


            int number3 = 30;
            WriteLine(number3);         //30
            WriteLine(++number3);       //31
            WriteLine(--number3);       //30
            WriteLine(number3);         //30

            int number4 = 40;
            WriteLine(number4++);       //40
            WriteLine(++number4);       //41 + 1 = 42
            WriteLine(number4--);       //42출력 후 41로 감소
            WriteLine(--number4);       //40

            int number5 = 50;
            WriteLine(number5);     //50
            number5++;              //50 >> 51
            number5++;              //51 >> 52
            WriteLine(number5);     //52
            number5--;              //52 >> 51
            number5--;              //51 >> 50
            WriteLine(number5);     //50            

            WriteLine("");
            WriteLine("******************************************");

            WriteLine("");
            WriteLine("7. 자료형 검사 -> GetType()메서드 이용");
            WriteLine("");

            int i = 273;
            long l = 522731033265;
            float f = 52.273F;
            double d = 52.273;
            char c = '글';
            string str = "문자열";

            WriteLine(i.GetType());
            WriteLine(l.GetType());
            WriteLine(f.GetType());
            WriteLine(d.GetType());
            WriteLine(c.GetType());
            WriteLine(str.GetType());




        }
    }
}
