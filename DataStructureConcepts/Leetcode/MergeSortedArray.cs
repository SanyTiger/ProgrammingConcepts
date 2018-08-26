using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class MergeSortedArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums1 = new int[8];
            nums1[0] = 1;
            nums1[1] = 3;
            nums1[2] = 5;
            nums1[3] = 7;
            var nums2 = new int[4] { 2, 4, 6, 8 };
            new MergeSortedArraySolution().Merge(nums1, 4, nums2, nums2.Length);
        }
    }
    public class MergeSortedArraySolution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0 && n == 0)
                return;
            else
            {
                var pos = 0;
                for (var i = m; i < nums1.Length; i++)
                {
                    nums1[i] = nums2[pos];
                    ++pos;
                }
                Array.Sort(nums1);
            }
        }
    }
}
