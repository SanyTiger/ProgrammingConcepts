using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    /*
    Given an array S of n integers, are there elements a, b, c in S such that a + b + c = 0? Find all unique triplets in the array which gives the sum of zero.

    Note: The solution set must not contain duplicate triplets.

    For example, given array S = [-1, 0, 1, 2, -1, -4],

    A solution set is:
    [
      [-1, 0, 1],
      [-1, -1, 2]
    ]
    */

    [TestClass]
    public static class ThreeSum
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class ThreeSumSolution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var lstSolution = new List<IList<int>>();
            var lstArray = new List<int>();
            for (int i = 0; i < nums.Length - 2; i++)
            {
                lstArray.Clear();
                lstArray.Add(nums[i]);
                for (int j = (i + 1); j < nums.Length; j++)
                {
                    lstArray.Add(nums[j]);
                    if (lstArray.Count == 3)
                    {
                        if (lstArray[0] + lstArray[1] + lstArray[2] == 0)
                        {
                            if (!lstSolution.Contains(lstArray))
                                lstSolution.Add(new List<int> { lstArray[0], lstArray[1], lstArray[2] });
                        }

                        lstArray.RemoveAt(2);
                        lstArray.RemoveAt(1);
                    }
                }
            }
            return lstSolution;
        }
    }
}
