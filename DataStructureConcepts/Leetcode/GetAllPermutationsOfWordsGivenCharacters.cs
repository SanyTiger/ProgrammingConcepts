using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Leetcode
{
    [TestClass]
    public class GetAllPermutationsOfWordsGivenCharacters
    {
        [TestMethod]
        public void TestMethod1()
        {
            var root = new TrieNodeDict(string.Empty);
            var lstWords = new List<string>() { "Sea" };
            var charWords = new char[4] { 's', 'e', 'a', 'z' };
            root.InsertIntoDict(lstWords, ref root);
            var sol = new PermutationsOfWordsSolution().GetPermutationsOfWords(charWords, root);
        }
    }
    public class TrieNodeDict
    {
        public static int alphabets = 26;
        public TrieNodeDict[] characters = new TrieNodeDict[alphabets];
        public string letter;
        public bool isEnd;

        public TrieNodeDict(string str)
        {
            letter = str;
            isEnd = false;
            for (var i = 0; i < alphabets; i++)
                characters[i] = null;
        }
        public void InsertIntoDict(List<string> lstWords, ref TrieNodeDict root)
        {
            var crawl = root;
            foreach(var word in lstWords)
            {
                var lowerWord = word.ToLower();
                for(var i = 0; i < lowerWord.Length; i++)
                {
                    var index = lowerWord[i] - 'a';
                    if (crawl.characters[index] == null)
                        crawl.characters[index] = new TrieNodeDict(Convert.ToString(lowerWord[i]));
                    crawl = crawl.characters[index];
                }
                crawl.isEnd = true;
            }
        }
    }

    public class PermutationsOfWordsSolution
    {
        public List<string> GetPermutationsOfWords(char[] charaters, TrieNodeDict root)
        {
            var tempCharLst = new List<char>();
            var resultLst = new List<string>();

            return resultLst;
        }
    }
}
