using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * 79/230 test cases passed
     */ 
    [TestClass]
    public class _032_LongestValidParentheses
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new LongestValidParenthesesSolution().LongestValidParentheses("()(()");
        }
    }
    public class LongestValidParenthesesSolution
    {
        public int LongestValidParentheses(string s)
        {
            var hash = new List<char>();

            if (s.Length == 0 || s.Length == 1)
                return 0;

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == ')' && hash.Contains('('))
                    hash.Remove('(');
                else
                    hash.Add(s[i]);
            }
            return s.Length - hash.Count;
        }
    }
}
