using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DynamicProgramming
{
    [TestClass]
    public class LongestPalindromeSubstring
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var sol = new LongestPalindromeSubstringSolution();
            //var str = sol.LongestPalindrome("aaaabaaa");
            //var boss = str;
        }
    }

    /*
    * Test Cases = 48/92
    * */
    #region Non Dynamic Approach
    // Non Dynamic Approach
    public class LongestPalindromeSubstringSolution
    {
        public string LongestPalindrome(string s)
        {
            var len = s.Length;
            var i = 0;
            var lstStr = new List<string>();
            var newStr = string.Empty;
            var retStr = string.Empty;
            var isNew = true;

            if (len == 0 || len == 1 || len == 2 || isPalindrome(ref s, true))
                return s;
            else
            {
                while (i < len)
                {
                    if (!newStr.Contains(char.ToString(s[i])))
                        newStr += char.ToString(s[i]);
                    else
                    {
                        newStr += char.ToString(s[i]);
                        if (isPalindrome(ref newStr, false))
                        {
                            lstStr.Add(newStr);
                            if (newStr.Length >= retStr.Length)
                                retStr = newStr;
                            if (++i < len && char.ToString(s[i]).Equals(char.ToString(s[i / 2])))
                            {
                                newStr += char.ToString(s[i]);
                                isNew = false;
                            }
                            else
                            {
                                newStr = string.Empty;
                                isNew = true;
                            }
                        }
                    }
                    i++;
                    if (i == len && !isNew && s.Length > lstStr[0].Length)
                    {
                        newStr = string.Empty;
                        i = 0;
                        s = s.Substring(lstStr[0].Length);
                        len = s.Length;
                    }
                }
            }
            return retStr;
        }
        public bool isPalindrome(ref string s, bool isIt)
        {
            if (!isIt)
            {
                while (!char.ToString(s[0]).Equals(char.ToString(s[s.Length - 1])))
                    s = s.Substring(1);
            }
            var originalS = s;
            var arrS = s.ToCharArray();
            Array.Reverse(arrS);
            var reverseS = new string(arrS);
            return originalS == reverseS ? true : false;
        }
    }
    #endregion

    #region Dynamic Approach
    public class LongestPalindromeSubstringDynamicSolution
    {

    }
    #endregion
}
