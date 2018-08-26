using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _033_SearchInRotatedSortedArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[3] { 3, 5, 1 };
            var sol = new SearchInRotatedSortedArraySolution().Search(nums, 5);
        }
    }
    public class SearchInRotatedSortedArraySolution
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
                return -1;
            if (nums.Length == 1 && nums[0] != target)
                return -1;
            if (nums.Length == 1 && nums[0] == target)
                return 0;

            var first = 0;
            var last = nums.Length - 1;
            var pos = -1;
            while (first <= last)
            {
                if (nums[first] == target)
                {
                    pos = first;
                    break;
                }
                if (nums[last] == target)
                {
                    pos = last;
                    break;
                }
                if (nums[first] < target)
                    ++first;
                else if (nums[last] > target)
                    --last;
                else
                    break;
            }
            return pos;
        }
    }
}
