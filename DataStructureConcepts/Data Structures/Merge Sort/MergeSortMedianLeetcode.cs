using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.MergeSort
{
    /*
    There are two sorted arrays nums1 and nums2 of size m and n respectively.

    Find the median of the two sorted arrays.The overall run time complexity should be O(log (m+n)).

    Example 1:
    nums1 = [1, 3]
    nums2 = [2]

    The median is 2.0
    Example 2:
    nums1 = [1, 2]
    nums2 = [3, 4]

    The median is (2 + 3)/2 = 2.5
    */

    [TestClass]
    public class MedianOfTwoSortedArrays
    {
        [TestMethod]
        public void TestMethod1()
        {
            var m = new int[] { 1, 2 };
            var n = new int[] { 3, 4 };
            var sol = MedianOfTwoSortedArraysSolution.FindMedianSortedArrays(m, n);
        }
    }
    public static class MedianOfTwoSortedArraysSolution
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            var m = nums1.Length;
            var n = nums2.Length;
            var solution = 0.0;
            if (m == 0 && n == 0)
                return 0.0;
            else if (m != 0 && n == 0)
            {
                solution = FindMedian(nums1);
            }
            else if (m == 0 && n != 0)
            {
                solution = FindMedian(nums2);
            }

            // Merge Sort
            else
            {
                var i = 0;
                var j = 0;
                var k = 0;
                var arr = new int[m + n];
                while (i < m && j < n)
                {
                    if (nums1[i] <= nums2[j])
                    {
                        arr[k] = nums1[i];
                        i++;
                    }
                    else if (nums1[i] > nums2[j])
                    {
                        arr[k] = nums2[j];
                        j++;
                    }
                    k++;
                }
                // Add to new array any left over elements from sub-array
                while (i < m)
                {
                    arr[k] = nums1[i];
                    i++;
                    k++;
                }
                // Add to new array any left over elements from sub-array
                while (j < n)
                {
                    arr[k] = nums2[j];
                    j++;
                    k++;
                }
                solution = FindMedian(arr);
            }
            return solution;
        }
        public static double FindMedian(int[] arr)
        {
            double solution = 0.0;
            double low = 0;
            double high = arr.Length - 1;
            double median = (low + high) / 2;
            if (median % 2 == 0)
                solution = Convert.ToDouble(arr[Convert.ToInt32(median)]);
            else
            {
                double median1 = Math.Floor(median);
                double median2 = Math.Ceiling(median);
                solution = (Convert.ToDouble(arr[Convert.ToInt32(median1)]) + Convert.ToDouble(arr[Convert.ToInt32(median2)])) / 2;
            }
            return solution;
        }
    }
}
