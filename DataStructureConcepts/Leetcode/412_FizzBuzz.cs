using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureConcepts.Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _412_FizzBuzz
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class FizzBuzzSolution
    {
        public IList<string> FizzBuzz(int n)
        {
            var lst = new List<string>();
            lst.Add("1");
            if (n >= 2)
                lst.Add("2");
            if (n > 2)
            {
                for (var i = 3; i <= n; ++i)
                {
                    if (i > 5 && i % 3 == 0 && i % 5 == 0)
                        lst.Add("FizzBuzz");
                    else if (i % 5 == 0)
                        lst.Add("Buzz");
                    else if (i % 3 == 0)
                        lst.Add("Fizz");
                    else
                        lst.Add(i.ToString());
                }
            }
            return lst;
        }
    }
}
