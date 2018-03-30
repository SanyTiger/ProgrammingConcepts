using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class PowXN
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class PowXNSolution
    {
        public double MyPow(double x, int n)
        {
            if (x == 0.0)
                return 0;
            if (n == 0)
                return 1;
            return Math.Pow(x, n);
        }
    }
}
