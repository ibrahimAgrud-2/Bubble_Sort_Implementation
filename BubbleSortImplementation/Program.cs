﻿using System;
using System.Dynamic;

namespace BubbleSort
{
    class Program
    {

        public static void swapArrayElements(ref int val1, ref int val2)
        {
            (val1, val2) = (val2, val1);
        }
        public static void ComputeBubbleSort(ref int[] array)
        {

            bool isChanged;
            for (int i = 0; i < array.Length; i++)
            {
                isChanged = true;
                for (int j = 0; j < (array.Length - i) - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        swapArrayElements(ref array[j], ref array[j + 1]);
                        isChanged = false;
                    }

                }
                if (isChanged)
                {
                    return;
                }
            }
        }

        public static void Main()
        {
            Console.Clear(); //ctrl+shift+I


            int[] array = { 100, 45, 80, 17, 34, 10 };
            int[] array2 = { 1, 34, 3, 4, 6, 5 };

            ComputeBubbleSort(ref array2);

            foreach (var item in array2)
            {
                System.Console.Write(item + " ");
            }
        }

    }
}