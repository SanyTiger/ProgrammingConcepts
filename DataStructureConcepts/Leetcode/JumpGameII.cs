using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    Given an array of non-negative integers, you are initially positioned at the first index of the array.

    Each element in the array represents your maximum jump length at that position.

    Your goal is to reach the last index in the minimum number of jumps.

    For example:
    Given array A = [2, 3, 1, 1, 4]

    The minimum number of jumps to reach the last index is 2. (Jump 1 step from index 0 to 1, then 3 steps to the last index.)

    Note:
    You can assume that you can always reach the last index.
    */

    [TestClass]
    public static class JumpGameII
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class JumpGameIISolution
    {
        public static int Jump(int[] nums)
        {
            try
            {
                var lastIndex = nums.Length - 1;
                var jump = 0;
                var pos = 0;
                var i = nums[pos];
                var max = nums[pos] + pos;
                if (lastIndex == 0)
                    jump = 0;
                else if (lastIndex == 1 || i >= lastIndex)
                    ++jump;
                else
                {
                    while (max < lastIndex)
                    {
                        if (lastIndex == 0)
                            break;
                        else if ((nums[max] == 0 || nums[max] == 1) && pos != 0)
                        {
                            ++max;
                            ++jump;
                            if (max == lastIndex && nums[max] == 0 && nums[max - 1] != 0)
                                break;
                        }
                        else if (i >= lastIndex)
                        {
                            ++jump;
                            break;
                        }
                        else
                        {
                            ++jump;
                            pos = max < lastIndex ? max == 1 ? max : getBestPos(max, pos, nums) : lastIndex;
                            i = nums[pos];
                            max = nums[pos] + pos;
                        }
                        jump = max >= lastIndex ? ++jump : jump;
                    }
                }
                return jump;
            }
            catch (Exception ex)
            { throw; }
        }
        public static int getBestPos(int max, int pos, int[] nums)
        {
            var bestPos = max;
            var bestValue = nums[max];
            var highestPos = nums.Length - 1;

            if ((nums.Length - 1) - nums[bestPos] == nums[bestPos])
                return bestPos;
            else
            {
                for (int i = (pos + 1); i <= max; i++)
                {
                    if (nums[i] > nums[bestPos])
                    {
                        // check if this current node is better than other nodes by comparing difference of lastIndex position to to current node + value
                        var newMaxPos = nums[i] + i;
                        if (newMaxPos < nums.Length - 1)
                        {
                            if ((highestPos - (nums[newMaxPos] + newMaxPos)) > (nums[bestPos] + bestPos))
                                bestPos = newMaxPos;
                        }
                        else
                            bestPos = i;
                    }
                }
                return bestPos;
            }
        }
    }
}
