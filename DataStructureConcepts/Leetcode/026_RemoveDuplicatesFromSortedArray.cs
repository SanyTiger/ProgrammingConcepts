using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _026_RemoveDuplicatesFromSortedArray
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[3] { 1, 1, 2 };
            var sol = new RemoveDuplicatesFromSortedArray().RemoveDuplicates(nums);
        }
    }
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            //return new HashSet<int>(nums).ToArray<int>().Count();

            if (nums.Length == 0)
                return 0;
            var count = 1;
            for(var i = 0; i < nums.Length; i++)
            {
                if (i == nums.Length - 1)
                    break;
                else if (nums[i] != nums[i + 1])
                {
                    nums[count] = nums[i + 1];
                    ++count;
                }
            }
            return count;
        }
    }
}
