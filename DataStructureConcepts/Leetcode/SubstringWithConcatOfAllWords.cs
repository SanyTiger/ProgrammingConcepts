using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureConcepts.Leetcode
{
    /*
     * Test Cases: 23 / 169
     */
    [TestClass]
    public class SubstringWithConcatOfAllWords
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arrWords = new string[2] { "foo", "bar" };
            var sol = new SubstringWithConcatOfAllWordsSolution().FindSubstring("barfoothefoobarman", arrWords);
            var result = sol;
        }
    }
    public class SubstringWithConcatOfAllWordsSolution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var strWord = string.Empty;
            var pos = 0;
            var isMatch = false;
            var lstResult = new List<int>();

            if (s.Length == 0 || words.Length == 0)
                return lstResult;

            for (int i = 0; i < words.Length; i++)
                strWord += words[i];
            for (int i = 0; i < s.Length; i++)
            {
                if (lstResult.Count == 0)
                    lstResult.Add(i);
                else if (pos == strWord.Length && isMatch)
                    break;
                else if (s[i] == strWord[pos])
                {
                    if (lstResult.Count == 1)
                        lstResult.Add(i);
                    ++pos;
                    isMatch = true;
                }
                else
                {
                    if (lstResult.Count == 2)
                        lstResult.RemoveAt(1);
                    pos = 0;
                    isMatch = false;
                }
            }
            return lstResult;
        }
    }
}
