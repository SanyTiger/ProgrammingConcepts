using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public static class _001_TwoSum
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
