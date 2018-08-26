using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * 72/75 test cases passed
     */
    [TestClass]
    public class _055_JumpGame
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[5] { 3, 2, 1, 0, 4 };
            var sol = new JumpGameSolution().CanJump(nums);
        }
    }
    public class JumpGameSolution
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 0)
                return false;
            if (nums.Length == 1)
                return true;

            var val = nums[0];
            while (val > 0)
            {
                var isTrue = CanJump((nums.Skip(val).Take(nums.Length - 1)).ToArray());
                if (isTrue)
                    return isTrue;
                else
                    --val;
            }
            return false;
        }
    }
}
