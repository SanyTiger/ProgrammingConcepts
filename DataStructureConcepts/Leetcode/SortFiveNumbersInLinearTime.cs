using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    [TestClass]
    public class SortFiveNumbersInLinearTime
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[5] { 300, 201, 47, 1, 100 };
            var res = new SortFiveNumbersInLinearTimeSolution().SortNums(nums);
        }
    }
    public class SortFiveNumbersInLinearTimeSolution
    {
        public int[] SortNums(int[] nums)
        {
            GetSortedArray(ref nums, 0, nums.Length - 1);
            GetSortedArray(ref nums, 1, nums.Length - 1);
            GetSortedArray(ref nums, 2, nums.Length - 1);
            GetSortedArray(ref nums, 3, nums.Length - 1);
            GetSortedArray(ref nums, 4, nums.Length - 1);
            return nums;
        }
        public int[] GetSortedArray(ref int[] nums, int first, int last)
        {
            while (first < last)
            {
                if (nums[first] < nums[last])
                {
                    var temp = nums[last];
                    nums[last] = nums[first];
                    nums[first] = temp;

                    ++first;
                }
                else
                    --last;
            }
            return nums;
        }
    }
}
