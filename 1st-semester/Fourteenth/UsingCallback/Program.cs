﻿using System;
using static System.Console;

namespace UsingCallback
{
    delegate int Compare(int a, int b);
    class Program
    {
        //오름차순 정리
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        //내림차순 정리
        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)   //앞의 원소가 더큼
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array1 = { 3, 7, 4, 2, 10 };
            Console.WriteLine("Sorting ascending...");
            //콜백 메소드 이용
            //BubbleSort(array1, new Compare(AscendCompare));

            //무명 메소드 이용
            BubbleSort(array1, delegate(int a, int b) {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });
            for (int i = 0; i < array1.Length; i++)
                Console.Write($"{array1[i]} ");
            Console.WriteLine();

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            //콜백 메소드 이용
            BubbleSort(array2, new Compare(DescendCompare));

            //무명 메소드 이용
            BubbleSort(array2, delegate(int a, int b)
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });
            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");
        }
    }
}
