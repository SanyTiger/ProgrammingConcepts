using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class LongestSubstring
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new LongestSubstringSolution().LengthOfLongestSubstring("dvdf");
            var result = sol;
        }
    }

    #region Non-Dynamic Approach
    public class LongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var hash = new HashSet<char>();
            var current = 0;
            var next = current + 1;
            var max = 0;
            if (s.Equals(string.Empty))
                return 0;
            if (s.Length == 1)
                return 1;

            hash.Add(s[current]);
            while (next < s.Length)
            {
                if (hash.Contains(s[next]))
                {
                    max = next > max ? next : max;
                    s = s.Substring(++current);
                    current = 0;
                    next = current + 1;
                    hash = new HashSet<char>();
                    hash.Add(s[current]);
                }
                else
                {
                    hash.Add(s[next]);
                    ++next;
                }
            }
            max = next > max ? next : max;
            return max;
        }
        #endregion
    }
    #region Dynamic Approach
    public class LongestSubstringSolutionDynamic
    {

    }
    #endregion
}
