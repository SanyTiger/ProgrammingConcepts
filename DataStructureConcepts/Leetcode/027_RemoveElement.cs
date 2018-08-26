using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _027_RemoveElement
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class RemoveElementc
    {
        public int RemoveElement(int[] nums, int val)
        {
            if (nums.Length == 0)
                return 0;
            var pos = 0;
            var count = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[pos] = nums[i];
                    ++pos;
                    ++count;
                }
            }
            return count;
        }
    }
}
