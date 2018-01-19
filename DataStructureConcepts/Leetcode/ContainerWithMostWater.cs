using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * Test Cases: 47 / 49
     */
    [TestClass]
    public class ContainerWithMostWater
    {
        /*
            Given n non-negative integers a1, a2, ..., an, where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of line i is at (i, ai) and (i, 0). Find two lines, which together with x-axis forms a container, such that the container contains the most water.
            Note: You may not slant the container and n is at least 2.

            Input : [1, 5, 4, 3]
            Output : 6
            Explanation : 
            5 and 3 are distance 2 apart. 
            So the size of the base = 2. 
            Height of container = min(5, 3) = 3. 
            So total area = 3 * 2 = 6

            Input : [3, 1, 2, 4, 5]
            Output : 12
            Explanation : 
            5 and 3 are distance 4 apart. 
            So the size of the base = 4. 
            Height of container = min(5, 3) = 3. 
            So total area = 4 * 3 = 12
         */
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

            // O(n) complexity
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

            // O(n^2) complexity
            /*for (int i = 1; i < len; i++)
            {
                for (int j = i; j < len; j++)
                {
                    var baseValue = pos > j ? pos - j : j - pos;
                    var result = baseValue * Math.Min(height[pos], height[j]);
                    if (result > largest)
                        largest = result;
                }
                ++pos;
            }*/
            return largest;
        }
    }
}
