using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * 17/94 test cases passed
     */ 
    [TestClass]
    public class _005_LongestPalindromeSubstring
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new LongestPalindromeSubstringSolution().LongestPalindrome("bananas");//aaaabaaa //ccc
            var result = sol;
        }
    }
    public class LongestPalindromeSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            var palStr = string.Empty;

            if (s.Length == 0 || s.Length == 1)
                return s;
            else if (s.Length == 2)
            {
                if (s[0] == s[1])
                    return s;
                else
                    return Convert.ToString(s[0]); // or Convert.ToString(s[1]);
            }
            else
                GetLongestPalindrome(s, 0, 1, Convert.ToString(s[0]), ref palStr);

            return palStr;
        }
        public void GetLongestPalindrome(string givenStr, int current, int next, string palStr, ref string longSubStr)
        {
            var tempStr = string.Empty;
            while (next < givenStr.Length)
            {
                if (givenStr.Length == 2)
                    break;
                if (next == givenStr.Length - 1)
                {
                    if (palStr.Length >= longSubStr.Length)
                        longSubStr = palStr;

                    givenStr = givenStr.Substring(longSubStr.Length);
                    current = 0;
                    next = 0;
                    palStr = Convert.ToString(givenStr[0]);
                    tempStr = string.Empty;
                }
                else if (givenStr[current] == givenStr[next])
                {
                    palStr += tempStr + Convert.ToString(givenStr[next]);
                    tempStr = string.Empty;
                }
                else
                    tempStr += Convert.ToString(givenStr[next]);
                ++next;
            }
        }
    }
}
