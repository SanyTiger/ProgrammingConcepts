using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    Given an array of integers, return indices of the two numbers such that they add up to a specific target.

    You may assume that each input would have exactly one solution, and you may not use the same element twice.

    Example:
    Given nums = [2, 7, 11, 15], target = 9,

    Because nums[0] + nums[1] = 2 + 7 = 9,
    return [0, 1].
    */


    [TestClass]
    public static class TwoSum
    {
        [TestMethod]
        public static void TestMethod1()
        {
 
        }
    }
    public static class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] n = new int[2];
            return returnSum(nums.Length - 1, nums, target, n);
        }
        public static int[] returnSum(int pos, int[] nums, int target, int[] n)
        {
            for (int i = 0; i <= pos; i++)
            {
                if ((nums[i] + nums[pos]) == target && i != pos)
                {
                    n[0] = i;
                    n[1] = pos;
                    break;
                }
            }
            if (n[0] == 0 && n[1] == 0)
                return returnSum((pos - 1), nums, target, n);
            else
                return n;
        }
    }
}
