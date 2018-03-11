using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class ValidParentheses
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new ValidParenthesesSolution().IsValid("(}");
        }
    }
    public class ValidParenthesesSolution
    {
        public bool IsValid(string s)
        {

            var lstList = new List<char>();
            if (s == string.Empty)
                return true;
            else if (s.Length == 1)
                return false;
            else
            {
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                        lstList.Add(')');
                    if (s[i] == '{')
                        lstList.Add('}');
                    if (s[i] == '[')
                        lstList.Add(']');
                    else
                    {
                        if (s[i] == ')')
                            CheckValidity(s[i], ref lstList);
                        if (s[i] == '}')
                            CheckValidity(s[i], ref lstList);
                        if (s[i] == ']')
                            CheckValidity(s[i], ref lstList);
                    }
                }
            }
            if (lstList.Count == 0)
                return true;
            else
                return false;
        }
        public void CheckValidity(char s, ref List<char> lstList)
        {
            if (lstList.Contains(s))
                lstList.Remove(s);
        }
    }
}
