using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
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
        public static int Reverse(int x)
        {
            var reverseInt = 0;
            if (x > Int32.MaxValue || x < Int32.MinValue)
                return 0;
            else if (x < 0)
                reverseInt = isPalindrome(-x, true);
            else if (x < 10 && x >= 0)
                reverseInt = x;
            else
                reverseInt = isPalindrome(x, false);
            return reverseInt;
        }
        public static int isPalindrome(int x, bool isNeg)
        {
            var rev = 0.0;
            var i = x.ToString().Length - 1;
            while (x != 0)
            {
                rev += Math.Pow(10, i) * (x % 10);
                x /= 10;
                i--;
            }
            if (rev > Int32.MaxValue || rev < Int32.MinValue)
                return 0;
            return isNeg == true ? Convert.ToInt32(-rev) : Convert.ToInt32(rev);
        }
    } 
}
