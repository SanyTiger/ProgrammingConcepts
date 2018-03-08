using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    // Test Case: 143/212 

    [TestClass]
    public class NearestPalindromic
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new NearestPalindromicSolution().NearestPalindromic("1213");
        }
    }
    public class NearestPalindromicSolution
    {
        public string NearestPalindromic(string n)
        {
            var result = string.Empty;

            if (n == string.Empty)
                return "0";
            else
            {
                var num = Convert.ToInt64(n);
                var forward = FindPalindromeForward(num);
                var backward = FindPalindromeBackward(num);

                if (forward - num < num - backward)
                    result = Convert.ToString(forward);
                else
                    result = Convert.ToString(backward);
            }
            return result;
        }
        public long FindPalindromeForward(long num)
        {
            for (var i = num + 1; i < Int64.MaxValue; i++)
            {
                if (isPalindrome(i))
                    return i;
            }
            return Convert.ToInt64(0);
        }
        public long FindPalindromeBackward(long num)
        {
            for (var i = num - 1; i > 0; i--)
            {
                if (isPalindrome(i))
                    return i;
            }
            return Convert.ToInt64(0);
        }
        public bool isPalindrome(long num)
        {
            var n = num;
            var rev = 0.0;
            while(num != 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            if (Convert.ToInt64(n) == Convert.ToInt64(rev))
                return true;
            else
                return false;
        }
    }
}
