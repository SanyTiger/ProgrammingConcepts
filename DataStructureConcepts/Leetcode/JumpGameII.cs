using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    // Non Recursion Based
    /*
     * Test Cases: 46/92 (Failing at { 4, 1, 1, 3, 1, 1, 1 })
    */

    // Recursion Based
    /*
     * Test Cases: 71/92 (Time Exceeding)
     */

    [TestClass]
    public class JumpGameII
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new int[] { 4, 1, 1, 3, 1, 1, 1 };
            var sol = new JumpGameIISolution().Jump(arr);
        }
    }
    public class JumpGameIISolution
    {

        // Recursion Based
        public int minJump(int[] arr, int low, int high)
        {
            if (high == low)
                return 0;
            if (arr[low] == 0)
                return Int32.MaxValue;

            var min = Int32.MaxValue;
            for (int i = low + 1; i <= high && i <= low + arr[low]; i++)
            {
                var jumps = minJump(arr, i, high);
                if (jumps != Int32.MaxValue && jumps + 1 < min)
                    min = jumps + 1;
            }
            return min;
        }

        // Non Recursion Base
        public int Jump(int[] nums)
        {
            //return minJump(nums, 0, nums.Length - 1);

            var stepsShort = nums.Length - 1;
            var leastCount = 9999;
            if (nums.Length == 0)
                return 0;
            if (nums.Length == 1 && nums[0] >= 0)
                return 0;
            if (nums.Length == 2)
                return 1;
            else
            {
                for (int i = 0; i <= stepsShort; i++)
                {
                    var stepsLeft = stepsShort - nums[i] - i;
                    var subCount = i + 1;
                    var j = nums[i];
                    if (j == stepsShort)
                    {
                        subCount = i == 0 ? subCount : ++subCount;
                        if (subCount < leastCount)
                            leastCount = subCount;
                        break;
                    }
                    else if (j < stepsShort)
                    {
                        while (j <= stepsLeft)
                        {
                            stepsLeft = stepsLeft - nums[j];
                            j = nums[j];
                            ++subCount;
                        }
                        if (stepsLeft > 0)
                            subCount += stepsLeft;

                        if (subCount < leastCount)
                            leastCount = subCount;
                    }
                    else
                        leastCount = subCount;
                }
            }
            return leastCount;
        }
    }
}
