using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Trie
{
    [TestClass]
    public class TrieDataStructure
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new List<string> { "Apple", "Doctor", "Torque", "pluapp" };
            var sol = new ImplementTrie().TrieDataStructure(arr);
            var result = sol;
        }
    }
    public class TrieNode
    {
        public static int alphabet = 26;
        public string letter;
        public bool isEnd;
        public TrieNode[] children = new TrieNode[alphabet];
        public TrieNode(string l)
        {
            letter = l;
            isEnd = false;
            for (int i = 0; i < alphabet; i++)
                children[i] = null;
        }
    }
    public class ImplementTrie
    {
        public void Insert(string s, ref TrieNode root)
        {
            var crawl = root;
            for(int i = 0; i < s.Length; i++)
            {
                var index = s[i] - 'a';
                if (crawl.children[index] == null)
                    crawl.children[index] = new TrieNode(Convert.ToString(s[i]));
                crawl = crawl.children[index];
            }
            crawl.isEnd = true;
        }
        public TrieNode TrieDataStructure(List<string> s)
        {
            var root = new TrieNode(string.Empty);
            for (int i = 0; i < s.Count; i++)
                Insert(s[i].ToLower(), ref root);
            var result = Google(root, s);
            return root;
        }
        public List<List<string>> Google(TrieNode root, List<string> s)
        {
            var head = new List<List<string>>();
            var sub = new List<string>();
            for(int i = 0; i < s.Count; i++)
            {
                var lastThree = s[i].Substring(s[i].Length - 3).ToLower();
                if(isExists(lastThree, root))
                {
                    sub.Add(s[i]);
                    head.Add(sub);
                }
            }
            return head;
        }
        public bool isExists(string last, TrieNode root)
        {
            var crawl = root;
            for(int i = 0; i < last.Length; i++)
            {
                var index = last[i] - 'a';
                if (crawl.children[index] == null)
                    return false;
                crawl = crawl.children[index];
            }
            return true;
        }
    }
}
