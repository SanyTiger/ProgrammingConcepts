using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

/*
 * Test Cases: 240/265
 */ 
namespace Leetcode
{
    [TestClass]
    public class NextPermutation
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { 2, 3, 1 };
            new NextPermutationSolution().NextPermutation(nums);
        }
    }
    public class NextPermutationSolution
    {
        public void NextPermutation(int[] nums)
        {
            var len = nums.Length;
            if (len == 0 || len == 1)
                return;
            else
            {
                var max = GetMaxOfArray(nums);
                if (nums[0] == max)
                    SortInAscendingOrder(ref nums);
                else
                    ShiftPlaces(ref nums, len - 1, len - 2);
            }
        }
        public int GetMaxOfArray(int[] nums)
        {
            var max = -1;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }
            return max;
        }
        public void SortInAscendingOrder(ref int[] nums)
        {
            Array.Sort(nums);
        }
        public void ShiftPlaces(ref int[] nums, int last, int penultimate)
        {
            var originalNums = GetSumOfArray(ref nums);
            var newNums = -2;
            while (newNums < originalNums)
            {
                newNums = GetShiftedArray(ref nums, last, penultimate);
                if (originalNums > newNums)
                {
                    --last;
                    --penultimate;
                }
                if (penultimate == -1)
                {
                    var revOriginalNums = ReverseNums(newNums);
                    if (originalNums < revOriginalNums)
                        originalNums = revOriginalNums;
                    GetArrayFromSum(ref nums, originalNums);
                    break;
                }
            }
        }
        public int ReverseNums(int nums)
        {
            var temp = nums.ToString().ToCharArray();
            Array.Reverse(temp);
            return Convert.ToInt32(new string(temp));
        }
        public void GetArrayFromSum(ref int[] nums, int num)
        {
            var pos = 0;
            foreach(var n in num.ToString())
            {
                nums[pos] = Convert.ToInt32(n - 48);
                ++pos;
            }
        }
        public int GetSumOfArray(ref int[] nums)
        {
            var sum = nums[0];
            for (var i = 1; i < nums.Length; i++)
                sum = sum * 10 + nums[i];
            return sum;
        }
        public int GetShiftedArray(ref int[] nums, int last, int penultimate)
        {
            var temp = nums.GetValue(last);
            Array.Copy(nums, penultimate, nums, penultimate + 1, last - penultimate);
            nums.SetValue(temp, penultimate);
            return GetSumOfArray(ref nums);
        }
    }
}
