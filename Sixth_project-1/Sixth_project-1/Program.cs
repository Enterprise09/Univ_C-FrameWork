using System;
using static System.Console;

namespace Sixth_project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                        int score_1 = 80;
                        int score_2 = 74;
                        int score_3 = 81;
                        int score_4 = 90;
                        int score_5 = 34;

                        WriteLine(score_1);
                        WriteLine(score_2);
                        WriteLine(score_3);
                        WriteLine(score_4);
                        WriteLine(score_5);

                        int avg = (score_1 + score_2 + score_3 + score_4 + score_5) / 5;

                        WriteLine("Average : " + avg);      //기본 출력
                        WriteLine("Average : {0}", avg);    //String Format
                        WriteLine($"Average : {avg}");       //문자열 보간($)을 이용한 문자열 출력
            */
            /*
                        int[] scores = new int[5];
                        scores[0] = 80;
                        scores[1] = 74;
                        scores[2] = 81;
                        scores[3] = 90;
                        scores[4] = 34;
                        */
            /*
                        int[] scores = new int[5] { 86, 74, 81, 95, 67 };
                        int[] scores = new int[5] { 86, 74, 81, 95, 67 };
                        int[] scores = { 86, 74, 81, 95, 67 };
            */
            /*
                        foreach (int score in scores)
                        {
                            WriteLine(score);
                        }
            */

            //교재 p.195
            //4번

            //Length속성
            /*int[] intArr = { 52, 273, 32, 65, 103 };
            WriteLine(intArr);*/


            //무한 반복 : 종료하려면 [Ctrl] + [c]
            /*int i = 0;
            while (true)
            {
                i++;
                WriteLine(i);                   
                *//*WriteLine("무한반복");*//*
                
            }
*/

            //while, for반복문
            /*int i = 0;
            int[] intArr = { 52, 273, 32, 65, 103 };

            WriteLine("\"while반복문\"");
            WriteLine();

            for (i=0; i<intArr.Length; i++)
            {
                WriteLine(i + "번째 출력 : " + intArr[i]);
            }
*/
            /*while (i < intArr.Length)
            {
                WriteLine(i + "번째 출력 : " + intArr[i]);
                i++;
            }
            WriteLine();*/


            //p.197 문제10번


            //do while반복문
            /* string input;
             do
             {
                 WriteLine("입력(exit입력하면 종료) : ");
                 input = ReadLine();
             } while (input != "exit");
             WriteLine();
 */

            //for 반복문으로 덧셈하기
            /*int output = 0;
            for(int i =0; i<=100; i++)
            {
                output += i;
            }
            WriteLine(output);
            WriteLine();
*/

            //for 문으로 곱셉하기
            /*long output = 1;
            for (int i = 1; i <= 20; i++)
            {
                output *= i;
            }
            WriteLine(output);
            WriteLine();*/


            //p187 움직이는 달팽이! 실습해보기

            //별피라미드
            /*for (int i = 1; i <= 10; i++)
            {
                for(int j = 0; j <i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
            WriteLine();*/

            //p.195 문제4번, 문제 7번


            //p.197 11번문제 가운데 정렬 별피라미드 완성해보기
            
            for (int i = 1; i <= 10; i++)
            {
                int n = 10 - i / 2;
                WriteLine(n);
                for (int k = 1; k <= n; k++)
                {
                    Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    
                    
                    Write("*");
                    
                }
                WriteLine();
            }
            WriteLine();


        }
    }
}
