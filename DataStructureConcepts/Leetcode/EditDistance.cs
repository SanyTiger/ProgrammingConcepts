using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
    * Test Cases: 548/1520
    */
    [TestClass]
    public class EditDistance
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new EditDistanceSolution().MinDistance("mart", "karma");
            var result = sol;
        }
    }
    public class EditDistanceSolution
    {
        public int MinDistance(string word1, string word2)
        {

            return 1;
        }
    }
}
