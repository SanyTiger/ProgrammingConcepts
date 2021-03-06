﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    [TestClass]
    public class PositiveNegitiveSegregation
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new int[] { 1, 0, -3, 4, -5, 6, -7, 8, -9, -2 };
            var sol = new RearrangeSolution().Rearrange(arr);
        }
    }
    public class RearrangeSolution
    {
        public int[] Rearrange(int[] arr)
        {
            var low = 0;
            var high = arr.Length - 1;
            var min = low;
            while(low < arr.Length)
            {
                if (arr[high] < arr[min])
                    min = high;
                else if(low == high)
                {
                    var temp = arr[low];
                    arr[low] = arr[min];
                    arr[min] = temp;
                    ++low;
                    high = arr.Length;
                    min = low;
                }
                --high;
            }
            return arr;
        }


        // Quick Sort
        /*
        public int[] Rearrange(int[] arr)
        {
            sort(ref arr, 0, arr.Length - 1);
            return arr;
        }
        public int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            
            var swapTemp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = swapTemp;

            return i + 1;
        }

        public void sort(ref int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                sort(ref arr, low, pi - 1);
                sort(ref arr, pi + 1, high);
            }
        }
        */
    }
}
