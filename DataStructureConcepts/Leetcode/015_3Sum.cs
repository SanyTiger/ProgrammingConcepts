using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    /*
     * 226/313 test cases passed
     */
    [TestClass]
    public class _015_3Sum
    {
        [TestMethod]
        public void TestMethod1()
        {
            var nums = new int[] { 0, 3, 0, 1, 1, -1, -5, -5, 3, -3, -3, 0 };
            var sol = new ThreeSumSolution().ThreeSum(nums);
            var result = sol;
        }
    }
    public class ThreeSumSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var lstCombo = new List<IList<int>>();
            var lstNum = new List<int>();
            var dicNum = new Dictionary<int, int>();
            var tempNum = new Dictionary<int, int>();
            var len = nums.Length;
            var pos = 0;
            var onePos = pos + 1;
            var zeroCount = 0;

            lstCombo.Clear();

            if (len == 0 || len == 1 || len == 2)
                return lstCombo;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == 0)
                    ++zeroCount;
                dicNum.Add(i, nums[i]);
            }
            if (zeroCount == len)
                lstCombo.Add(new List<int> { 0, 0, 0 });
            else
            {
                while (pos < len && onePos < len)
                {
                    var diff = 0;
                    tempNum.Clear();
                    tempNum = tempNum.Concat(dicNum).ToDictionary(x => x.Key, x => x.Value);
                    if (onePos + 1 == len)
                    {
                        ++pos;
                        onePos = pos + 1;
                        continue;
                    }
                    diff = diff - nums[pos] - nums[onePos];
                    tempNum.Remove(pos);
                    tempNum.Remove(onePos);
                    if (tempNum.ContainsValue(diff))
                    {
                        lstNum.Add(nums[pos]);
                        lstNum.Add(nums[onePos]);
                        lstNum.Add(diff);
                        lstNum.Sort();
                        // Check for duplicates
                        if (!IsDuplicate(lstNum, lstCombo))
                            lstCombo.Add(new List<int> { lstNum[0], lstNum[1], lstNum[2] });
                        lstNum.Clear();
                    }
                    else if (onePos + 1 == len)
                        ++pos;
                    ++onePos;
                }
            }
            return lstCombo;
        }
        public bool IsDuplicate(List<int> lstNum, List<IList<int>> lstCombo)
        {
            var isTrue = false; 
            for(int i = 0; i < lstCombo.Count; i++)
            {
                var combo = lstCombo[i];
                if (!combo.Except(lstNum).Any()) // Broken library: [0, 0, 0] and [-1, 0, 1] is the same, apparently.
                    isTrue = true;
            }
            return isTrue;
        }
    }
}
