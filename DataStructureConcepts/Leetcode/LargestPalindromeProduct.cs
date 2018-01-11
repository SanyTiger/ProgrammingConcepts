using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    Find the largest palindrome made from the product of two n-digit numbers.

    Since the result could be very large, you should return the largest palindrome mod 1337.

    Example:

    Input: 2

    Output: 987

    Explanation: 99 x 91 = 9009, 9009 % 1337 = 987

    Note:

    The range of n is [1,8].
    */

    [TestClass]
    public static class LargestPalindromeProduct
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class LargestPalindromeProductSolution
    {
        public static int LargestPalindrome(int n)
        {
            if (n == 1)
                return 9;

            var a = Math.Pow(10, (n - 1)); // 100
            var b = Math.Pow(10, n) - 1;   // 999
            var ivalue = 0.0;
            var jvalue = 0.0;
            var largest = 0.0;
            for (double i = b; i >= (b - a); i--)
            {
                var value = i - 1;
                for (double j = value; j >= (b - a); j--)
                {
                    if (isPalindrome(i * j))
                    {
                        if ((i * j) > largest)
                        {
                            largest = i * j;
                            ivalue = i;
                            jvalue = j;
                        }
                    }
                }
            }
            return (int)(largest % 1337);
        }
        public static bool isPalindrome(double product)
        {
            var n = product;
            var sum = 0;
            while ((int)n > 0.0)
            {
                int r = (int)(n % 10);
                sum = 10 * sum + r;
                n = n / 10;
            }
            if ((double)sum == product)
                return true;
            else
                return false;
        }
    }
}
