using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
/*
* Test Cases: 42/988
*/
namespace Leetcode
{
    /*
    Divide two integers without using multiplication, division and mod operator.

    If it is overflow, return MAX_INT.
    */

    [TestClass]
    public static class DivideTwoIntegers
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class DivideTwoIntegerSolution
    {
        public static int Divide(int dividend, int divisor)
        {
            var d = divisor; ;
            var count = 1;
            while (divisor <= dividend)
            {
                divisor = divisor << 1; // 4
                count = count << 1;
            }
            divisor = divisor >> 1;
            count = count >> 1;
            var sum1 = dividend - divisor;
            var sum2 = divisor - sum1;
            var sum = sum1 + (sum2 / d);
            try
            {
                var q = 0;
                if (dividend > 0 && divisor > 0 && (divisor > dividend))
                    return 0;

                if ((dividend == int.MinValue && divisor == -1) || (dividend == int.MaxValue && divisor == 1))
                    return int.MaxValue;
                if ((dividend == int.MinValue && divisor == 1) || (dividend == int.MaxValue && divisor == -1))
                    return int.MinValue;

                if (dividend == int.MinValue || divisor == int.MinValue)
                {
                    if (dividend == int.MinValue)
                        dividend = int.MaxValue;
                    if (divisor == int.MinValue)
                        divisor = int.MaxValue;
                }

                if (dividend == 0)
                    return 0;

                else if (divisor == 0)
                    return int.MaxValue;

                else if (dividend >= 0 && divisor >= 0)
                    q = quotientAns(dividend, divisor);

                else if (dividend < 0 && divisor < 0)
                    q = quotientAns(-(dividend), -(divisor));

                else if (dividend < 0)
                {
                    q = quotientAns(-(dividend), divisor);
                    q = -q;
                }
                else if (divisor < 0)
                {
                    q = quotientAns(dividend, -(divisor));
                    q = -q;
                }
                return q;
            }
            catch (Exception ex)
            { throw; }
        }
        public static int quotientAns(int dividend, int divisor)
        {
            int count = 0;
            var div = dividend;
            while (dividend > 0)
            {
                var leftShift = dividend >> divisor;
                dividend = leftShift;
                count++;
            }
            return div / count * divisor;
        }
    }
}

