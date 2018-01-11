using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class LongestSubstring
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new LongestSubstringSolution();
            sol.LengthOfLongestSubstring("dvdf");
        }
    }
    public class LongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            var count = 0;
            var sub = string.Empty;
            var lstString = new List<string>();
            var i = 0;
            while (i < s.Length)
            {
                if (!sub.Contains(Char.ToString(s[i])))
                {
                    sub += Char.ToString(s[i]);
                    i++;
                    if (sub.Length > count)
                        count = sub.Length;
                }
                else if (!lstString.Contains(sub))
                {
                    lstString.Add(sub);
                    if (sub.Length > count)
                        count = sub.Length;
                    sub = string.Empty;
                    i--;
                }
                else
                {
                    i++;
                    sub = string.Empty;
                }
            }
            return count;
        }
    }
}
