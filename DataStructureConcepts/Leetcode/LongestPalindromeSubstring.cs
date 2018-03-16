using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class LongestPalindromeSubstring
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new LongestPalindromeSubstringDynamicSolution().LongestPalindrome("aaaabaaa");//aaaabaaa //ccc
            var result = sol;
        }
    }
    #region Non Dynamic Approach
    // Non Dynamic Approach
    public class LongestPalindromeSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            var current = 0;
            var next = current + 1;
            var max = string.Empty;
            if (s.Equals(string.Empty))
                return max;
            if (s.Length == 1)
                return s;

            while (next < s.Length)
            {
                if (s[current] == s[next])
                {
                    if (next > max.Length)
                        max = s.Substring(current, ++next);
                    s = s.Substring(++current);
                    current = 0;
                    next = current + 1;
                }
                if(next == s.Length - 1)
                {
                    s = s.Substring(++current);
                    current = 0;
                    next = current + 1;
                }
                else
                    ++next;
            }
            return max;
        }
    }
    #endregion

    #region Dynamic Approach
    public class LongestPalindromeSubstringDynamicSolution
    {
        public string LongestPalindrome(string s)
        {
            if (s.Equals(string.Empty))
                return s;
            if (s.Length == 1 || s.Length == 2)
                return Convert.ToString(s[0]);

            return Long(s, 0, 1, "");
        }
        public string Long(string s, int current, int next, string p)
        {

            if (current == s.Length - 1 && s[current] == p[0])
                return p + Convert.ToString(s[current]);
            else if (current >= next)
                return p;
            else if (s[current] == s[next])
            {
                if (p.Length < s.Substring(current, ++next).Length)
                    p = s.Substring(current, next);

                return Long(s.Substring(next), 0, 1, p);
            }
            else
                return Long(s, current, ++next, p);
        }
    }
    #endregion
}
