using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    Determine whether an integer is a palindrome.Do this without extra space.
    */

    [TestClass]
    public static class PalindromeNumber
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class PalindromeNumberSolution
    {
        public static bool IsPalindrome(int x)
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
