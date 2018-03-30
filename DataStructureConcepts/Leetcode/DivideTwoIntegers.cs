using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * Test Cases: 508/988
    */

    [TestClass]
    public class DivideTwoIntegers
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var sol = new DivideTwoIntegerSolution().Divide(5, 3);
            var sol = new DivideTwoIntegerBitManipulationSolution().Divide(-2147483648, 2);
            var result = sol;
        }
    }
    public class DivideTwoIntegerSolution
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0)
                return Int32.MaxValue;
            if (dividend == 0)
                return 0;
            if (divisor < 0 && dividend < 0)
            {
                divisor = divisor <= Int32.MinValue ? Int32.MaxValue : -divisor;
                dividend = dividend <= Int32.MinValue ? Int32.MaxValue : -dividend;
            }
            if (divisor == 1)
                return dividend >= Int32.MaxValue ? Int32.MaxValue : dividend;
            if (divisor > dividend)
                return 0;
            if (divisor == dividend)
                return 1;
            if (dividend % 2 == 0)
                return 0;
            if (divisor == 2)
                return 1;
            if (dividend < divisor)
                return dividend >= Int32.MaxValue ? Int32.MaxValue : divisor - dividend;
            return Divide(dividend - divisor, divisor);
        }
    }
    public class DivideTwoIntegerBitManipulationSolution
    {
        public int Divide(int dividend, int divisor)
        {
            //handle special cases
            if (divisor == 0) return int.MaxValue;
            if (divisor == -1 && dividend == int.MinValue)
                return int.MaxValue;

            //get positive values
            long pDividend = Math.Abs((long)dividend);
            long pDivisor = Math.Abs((long)divisor);

            int result = 0;
            while (pDividend >= pDivisor)
            {
                //calculate number of left shifts
                int numShift = 0;
                while (pDividend >= (pDivisor << numShift))
                    numShift++;

                //dividend minus the largest shifted divisor
                result += 1 << (numShift - 1);
                pDividend -= (pDivisor << (numShift - 1));
            }

            if ((dividend > 0 && divisor > 0) || (dividend < 0 && divisor < 0))
                return result;
            else
                return -result;
        }
    }
}

