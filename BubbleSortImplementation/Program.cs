﻿using System;
using System.Dynamic;

namespace BubbleSort
{
       class Program
       {

        public static void swapArrayElements(ref int val1,ref int val2)
        {
            (val1,val2)=(val2,val1);
        }
         
              public static void Main()
              {Console.Clear();
                    int[] arr = { 64, 34, 25, 12, 22, 11, 90 };


                    swapArrayElements(ref arr[0],ref arr[1]);

                    foreach (var item in arr)
                    {
                        System.Console.Write(item+" ");
                    }
            }

       }
}