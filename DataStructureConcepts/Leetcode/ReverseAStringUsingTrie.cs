using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class ReverseAStringUsingTrie
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class ReverseAStringUsingTrieSolution
    {
        public string ReverseAWord(string str)
        {
            var revStr = string.Empty;
            var root = new TrieNode(string.Empty);
            InsertIntoTrieNode(str.ToLower(), ref root);
            return GetReverse(str.ToLower(), root);
        }
        public string ReverseASentence(string str)
        {
            var revStr = string.Empty;

            return revStr;
        }
        public string ReverseASentenceInSameOrder(string str)
        {
            var revStr = string.Empty;

            return revStr;
        }
        public void InsertIntoTrieNode(string str, ref TrieNode root)
        {
            var crawl = root;
            for(var i = 0; i < str.Length; i++)
            {
                var index = str[i] - 'a';
                if(crawl.children[index] == null)
                    crawl.children[index] = new TrieNode(Convert.ToString(str[i]));
                crawl = crawl.children[index];
            }
            crawl.isEnd = true;
        }
        public string GetReverse(string str, TrieNode root)
        {
            var crawl = root;
            var revStr = string.Empty;
            return revStr;
        }
    }
    public class TrieNode
    {
        public static int alphabet = 26;
        public bool isEnd;
        public string letter;
        public TrieNode[] children = new TrieNode[alphabet];
        public TrieNode(string l)
        {
            letter = l;
            isEnd = false;
            for (var i = 0; i < alphabet; i++)
                children[i] = null;
        }
    }
}
