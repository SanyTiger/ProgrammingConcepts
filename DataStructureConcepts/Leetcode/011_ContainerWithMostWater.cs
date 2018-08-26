using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * 47/49 test cases passed
     */
    [TestClass]
    public class _011_ContainerWithMostWater
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new int[4] { 1, 2, 4, 3 };
            var sol = new ContainerWithMostWaterSolution().MaxArea(arr);
            var result = sol;
        }
    }
    public class ContainerWithMostWaterSolution
    {
        public int MaxArea(int[] height)
        {
            var len = height.Length;
            var largest = 0;
            var pos = 0;

            if (len == 0)
                return largest;
            else if (len == 1)
                return height[pos];

            largest = Math.Min(height[pos], height[pos + 1]);
            var j = 1;
            
            while (j <= len)
            {
                if (j == len && j == pos - 1)
                    break;
                else if (j == len && j != pos - 1)
                {
                    ++pos;
                    j = pos + 1;
                }
                if (j == len)
                    break;
                var baseValue = pos > j ? pos - j : j - pos;
                var result = baseValue * Math.Min(height[pos], height[j]);
                if (result > largest)
                    largest = result;
                ++j;
            }
            return largest;
        }
    }
}
