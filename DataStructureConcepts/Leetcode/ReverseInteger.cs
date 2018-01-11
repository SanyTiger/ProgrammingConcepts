using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    Given a 32-bit signed integer, reverse digits of an integer.

    Example 1:

    Input: 123
    Output:  321
    Example 2:

    Input: -123
    Output: -321
    Example 3:

    Input: 120
    Output: 21
    Note:
    Assume we are dealing with an environment which could only hold integers within the 32-bit signed integer range.For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.
    */

    [TestClass]
    public static class ReverseInteger
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class ReverseIntegerSolution
    {
        public static long Reverse(int x)
        {
            var isNeg = false;
            if (x < 0)
                isNeg = true;
            if (isNeg)
            {
                var rev = isPalindrome((x - x) - x);
                return -rev;
            }
            else
                return isPalindrome(x);
        }
        public static long isPalindrome(int n)
        {
            if (Math.Ceiling(Math.Log10(n)) >= 10)
                return 0;
            else
            {
                var m = n;
                long sum = 0;
                while (m > 0)
                {
                    int r = m % 10;
                    sum = 10 * sum + r;
                    m = m / 10;
                }
                return sum;
            }
        }
    } 
}
