using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    /*
     * Test Cases: 358 / 445
     */

    /*
    Implement regular expression matching with support for '.' and '*'.

    '.' Matches any single character.
    '*' Matches zero or more of the preceding element.

    The matching should cover the entire input string (not partial).

    The function prototype should be:
    bool isMatch(const char* s, const char* p)

    Some examples:
    isMatch("aa","a") → false
    isMatch("aa","aa") → true
    isMatch("aaa","aa") → false
    isMatch("aa", "a*") → true
    isMatch("aa", ".*") → true
    isMatch("ab", ".*") → true
    isMatch("aab", "c*a*b") → true
    */

    [TestClass]
    public class RegularExpressionMatching
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public static class RegularExpressionMatchingSolution
    {
        public static bool IsMatch(string s, string p)
        {
            try
            {
                if (s.Equals(p))
                    return true;
                else if (s.Equals(string.Empty) || p.Equals(string.Empty))
                    return false;
                else if ((s.Length == 1 || p.Length == 1) && !s.Equals(p))
                    return false;
                else if (!p.Contains("*") && s.Length != p.Length)
                    return false;
                else if (p.Equals(".*"))
                    return true;
                else if (s[0].Equals(p[0]))
                    return CompareValues(s, p, true);
                else if (!s[0].Equals(p[0]))
                    return CompareValues(s, p, false);
            }
            catch (Exception e)
            {
                throw;
            }
            return false;
        }
        public static bool CompareValues(string s, string p, bool output)
        {
            var sPos = 0;
            var pPos = 0;
            var pVal = '\0';
            if (p.Length == 2 && p[++pPos].Equals('*'))
                return output;
            else
            {
                do
                {
                    if (pPos < p.Length - 1)
                    {
                        pVal = p[pPos];
                        pPos++;
                    }
                    else
                        return output;
                }
                while (!p[pPos].Equals('*') && !p[pPos].Equals('.'));
                if (pPos < p.Length)
                {
                    if (output == true)
                    {
                        while (s[sPos].Equals(pVal) && p[pPos].Equals('*'))
                        {
                            ++sPos;
                            if (sPos == s.Length)
                                return true;
                        }
                    }
                    ++pPos;
                    return IsMatch(s.Substring(sPos, s.Length - sPos), p.Substring(pPos, p.Length - pPos));
                }
                else
                    return output;
            }
        }
    }
}
