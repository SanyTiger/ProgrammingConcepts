using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    * Test Cases: 362 / 445
    */ 
    [TestClass]
    public class RegularExpressionMatching
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new RegularExpressionMatchingSolution().IsMatch("aa", "a*");
            var result = sol;
        }
    }
    public class RegularExpressionMatchingSolution
    {
        public bool IsMatch(string s, string p)
        {
            if (s.Equals(string.Empty) && p.Equals(string.Empty))
                return true;
            if (s.Equals(string.Empty) || p.Equals(string.Empty))
                return false;
            if (s.Equals(p))
                return true;
            if (p.Equals(".*"))
                return true;

            return isValid(s, p, 0, 0);
        }
        public bool isValid(string s, string p, int m, int n)
        {
            if (m >= s.Length && n >= p.Length)
                return true;
            if (m >= s.Length || n >= p.Length)
                return false;
            if (p[n] == '.')
                return isValid(s, p, m + 1, n + 1);
            if (s[m] == p[n])
            {
                if (n < p.Length - 1 && p[n + 1] == '*')
                {
                    while (m <= s.Length - 1 && s[m] == p[n])
                        ++m;
                    if (m == s.Length)
                        return true;
                    else
                        return isValid(s, p, m, n + 2);
                }
                else
                    return isValid(s, p, m + 1, n + 1);
            }
            if (s[m] != p[n])
            {
                if (n < p.Length - 1 && p[n + 1] == '*')
                    return isValid(s, p, m + 1, n + 2);
                if (n < p.Length - 1 && p[n + 1] == '.')
                    return false;
                else
                    return false;
            }
            return isValid(s, p, m, n);
        }
    }
}
