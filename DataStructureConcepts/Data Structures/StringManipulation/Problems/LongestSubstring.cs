using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace StringManipulation
{
    /*
     * Test Cases: 473/983
     */

    [TestClass]
    public class LongestSubstring
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new LongestSubstringSolution();
            sol.LengthOfLongestSubstring("aab");
        }
    }

    #region Non-Dynamic Approach
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
                if (!sub.Contains(char.ToString(s[i])))
                {
                    sub += char.ToString(s[i]);
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
                    sub += char.ToString(s[i]);
                    lstString.Add(sub);
                    if (sub.Length > count)
                        count = sub.Length;
                    i++;
                    sub = string.Empty;
                }
            }
            return count;
        }
        #endregion
    }
    #region Dynamic Approach
    public class LongestSubstringSolutionDynamic
    {

    }
    #endregion
}
