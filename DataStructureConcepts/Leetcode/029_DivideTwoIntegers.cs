using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * All test cases passed
    */
    [TestClass]
    public class _029_DivideTwoIntegers
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new DivideTwoIntegerSolution().Divide(-2147483648, 2);
            var result = sol;
        }
    }
    public class DivideTwoIntegerSolution
    {
        public int Divide(int dividend, int divisor)
        {
            int sign = ((dividend < 0) ^
                    (divisor < 0)) ? -1 : 1;

            // Update both divisor and
            // dividend positive
            dividend = Math.Abs(dividend);
            divisor = Math.Abs(divisor);

            // Initialize the quotient
            int quotient = 0;

            while (dividend >= divisor)
            {
                dividend -= divisor;
                ++quotient;
            }
            return sign * quotient;
        }
    }
}

