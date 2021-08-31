using System;
using static System.Console;
using System.Collections.Generic;

namespace Random_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random Class 
            /*Random random = new Random();
            WriteLine(random.Next());
            WriteLine(random.Next(10));
            WriteLine(random.Next(100));
            WriteLine(random.Next(10, 100));
            WriteLine();
            WriteLine(random.NextDouble());*/

            //List 클래스
            //배열 생성
            /*int[] intArr = new int[10];
            long[] lArr = new long[10];
            string[] strArr = new long[10];
*/

            //List 클래스의 인스턴스 생성
            //변수 선언
            /*List<int> list = new List<int>();
            list.Add(52);
            list.Add(273);
            list.Add(32);       //인스턴스 메서드
            list.Add(64);
            list.Remove(52);*/

            /*foreach(var item in list)
            {
                WriteLine("Count : " + list.Count + "\titem : " + item);
            }*/

            /*List<int> list = new List<int> { 52, 273, 32, 64 };
            foreach(var item in list)
            {
                WriteLine("Count : " + list.Count + "\titem : " + item);
            }*/


            //Math 클래스
            WriteLine(Math.PI);     //클래스 변수
            WriteLine(Math.Abs(-5));    //클래스 메서드
            WriteLine(Math.Ceiling(52.273));
            WriteLine(Math.Min(52, 273));


        }
    }
}
