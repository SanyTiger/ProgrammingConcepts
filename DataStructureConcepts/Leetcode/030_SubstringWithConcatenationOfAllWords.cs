using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureConcepts.Leetcode
{
    /*
     * 69/174 test cases passed
     */
    [TestClass]
    public class _030_SubstringWithConcatenationOfAllWords
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arrWords = new string[4] { "word", "good", "best", "word" };
            var sol = new SubstringWithConcatOfAllWordsSolution().FindSubstring("wordgoodgoodgoodbestword", arrWords); 
            var result = sol;
        }
    }

    public class SubstringWithConcatOfAllWordsSolution
    {
        public IList<int> FindSubstring(string s, string[] words)
        {
            var lstPos = new List<int>();
            var wordsLength = 0;
            var startPos = 0;
            var endPos = 0;
            var isValid = true;

            if (words.Length == 0 || s.Length == 0)
                return lstPos;

            for (var i = 0; i < words.Length; i++)
                wordsLength += words[i].Length;

            while ((startPos + wordsLength) <= s.Length)
            {
                var str = s.Substring(startPos, wordsLength);
                for (var i = 0; i < words.Length; i++)
                {
                    if (endPos == 0)
                        endPos = startPos + words[i].Length;

                    if (!str.Contains(words[i]))
                    {
                        isValid = false;
                        break;
                    }
                }
                if(isValid)
                    lstPos.Add(startPos);

                startPos = endPos;
                endPos = 0;
                isValid = true;
            }
            return lstPos;
        }
    }
}
