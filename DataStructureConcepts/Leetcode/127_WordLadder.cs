using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace DataStructureConcepts.Leetcode
{
    /*
     * 17/39 test cases passed
     */
    [TestClass]
    public class _127_WordLadder
    {
        [TestMethod]
        public void TestMethod1()
        {
            var lst = new List<string> { "hot", "dot", "dog", "lot", "log", "cog" };
            var sol = new WordLadder().LadderLength("hit", "cog", lst);
        }
    }
    public class WordLadder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            if (wordList.Count == 0 || wordList.Count == 1 || wordList.Count == 2)
                return 0;
            if (endWord.Equals(string.Empty) || beginWord.Equals(string.Empty))
                return 0;
            if (!wordList.Contains(endWord))
                return 0;
            if (wordList.Contains(beginWord))
                wordList.Remove(beginWord);

            PlaceEndWordAtEndOfList(ref wordList, endWord);
            var count = 1;

            while (wordList.Contains(endWord))
            {
                for (var i = wordList.Count - 1; i >= 0 ; --i)
                {
                    if (isWordTransformedWithOneCharShift(beginWord, wordList[i]))
                    {
                        ++count;
                        beginWord = wordList[i];
                        wordList.RemoveAt(i);
                        break;
                    }
                    if (beginWord.Equals(endWord))
                        break;
                }
                if (count == 1)
                    return 0;
            }
            return count;
        }
        public void PlaceEndWordAtEndOfList(ref IList<string> wordList, string endWord)
        {
            var pos = wordList.IndexOf(endWord);
            var tempWord = wordList[pos];
            wordList.RemoveAt(pos);
            wordList.Add(tempWord);
        }
        public bool isWordTransformedWithOneCharShift(string str1, string str2)
        {
            return str1.Where((i, j) => !i.Equals(str2[j])).Count() == 1;
        }
    }
}
