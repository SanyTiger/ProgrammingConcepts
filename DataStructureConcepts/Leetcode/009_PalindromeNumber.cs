using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * All test cases passed
     */  
    [TestClass]
    public class _009_PalindromeNumber
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public class PalindromeNumberSolution
    {
        public bool IsPalindrome(int x)
        {
            var n = x;
            var sum = 0;
            while (n > 0)
            {
                sum = 10 * sum + n % 10;
                n = n / 10;
            }
            if (sum == x)
                return true;
            else
                return false;
        }
    }
}
