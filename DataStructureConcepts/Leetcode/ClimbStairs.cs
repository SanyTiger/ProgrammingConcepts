using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    You are climbing a stair case. It takes n steps to reach to the top.

    Each time you can either climb 1 or 2 steps.In how many distinct ways can you climb to the top?

    Note: Given n will be a positive integer.


    Example 1:

    Input: 2
    Output:  2
    Explanation:  There are two ways to climb to the top.

    1. 1 step + 1 step
    2. 2 steps
    Example 2:

    Input: 3
    Output:  3
    Explanation:  There are three ways to climb to the top.

    1. 1 step + 1 step + 1 step
    2. 1 step + 2 steps
    3. 2 steps + 1 step
    */

    [TestClass]
    public static class ClimbStairs
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class ClimbStairsSolution
    {
        public static int ClimbStairs(int n)
        {
            if (n <= 0)
                return 0;
            else if (n == 1)
                return 1;
            else if (n == 2)
                return 2;
            else
                return ClimbStairs(n - 1) + ClimbStairs(n - 2);
        }
    }
}
