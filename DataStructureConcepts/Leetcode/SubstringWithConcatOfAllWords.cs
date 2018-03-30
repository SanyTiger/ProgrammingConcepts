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
            var arrWords = new string[2] { "aa", "aa" };
            var sol = new SubstringWithConcatOfAllWordsSolution().FindSubstring("aaa", arrWords); 
            var result = sol;
        }
    }
    public class SubstringWithConcatOfAllWordsSolution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var hash = new HashSet<string>();
            var lst = new List<int>();
            var pos = 0;

            if (s.Equals(string.Empty) || words.Length == 0)
                return lst;

            foreach (var w in words)
                hash.Add(w);

            lst = getSubstring(s, hash, lst, words[0].Length, pos);
            var len = lst.Count;
            lst.RemoveAt(len - 1);
            return lst;
        }
        public List<int> getSubstring(string s, HashSet<string> hash, List<int> lst, int len, int pos)
        {
            var tempHash = new HashSet<string>();
            var tempPos = pos;
            var subStringCount = 0;
            lst.Add(pos);

            while (pos < s.Length)
            {
                var str = s.Substring(pos, len);
                if (subStringCount == hash.Count * len)
                {
                    tempPos += len;
                    return getSubstring(s, hash, lst, len, tempPos);
                }
                if (!tempHash.Contains(str) && hash.Contains(str))
                {
                    subStringCount += len;
                    pos += len;
                    tempHash.Add(str);
                    continue;
                }
                else
                {
                    lst.Remove(tempPos);
                    tempPos += len;
                    return getSubstring(s, hash, lst, len, tempPos);
                }
            }
            return lst;
        }
    }
}
