using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _034_SearchForARange
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class SearchForARangeSolution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var arr = new int[2] { -1, -1 };

            if (nums.Length == 0)
                return arr;
            if (nums.Length == 1 && nums[0] == target)
                return new int[2] { 0, 0 };
            if (nums.Length == 2 && nums[0] == target && nums[1] == target)
                return new int[2] { 0, 1 };

            var first = 0;
            var last = nums.Length - 1;
            while (first < last)
            {
                if (nums[first] == target)
                    arr[0] = first;
                if (nums[last] == target)
                    arr[1] = last;
                if (nums[first] < target)
                    ++first;
                else if (nums[last] > target)
                    --last;
                else
                    break;
            }
            if (arr[0] == -1)
                arr[0] = arr[1];
            else if (arr[1] == -1)
                arr[1] = arr[0];

            return arr;
        }
    }
}
