using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class ReverseAString
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new ReverseAStringSolution();
            sol.ReverseAWord("HelloWorld");
            sol.ReverseASentence("Hello From The Other Side");
            sol.ReverseASentenceInSameOrder("We do not forgive we do not forget");
        }
    }
    public class ReverseAStringSolution
    {
        public string ReverseAWord(string str)
        {
            var revStr = string.Empty;
            for (var i = str.Length - 1; i >= 0; i--)
                revStr += Convert.ToString(str[i]);
            return revStr;
        }
        public string ReverseASentence(string str)
        {
            var revStr = string.Empty;
            var lstWords = str.Split(' ').ToList();
            foreach(var word in lstWords)
            {
                revStr += ReverseAWord(word);
                revStr += " ";
            }
            return revStr;
        }
        public string ReverseASentenceInSameOrder(string str)
        {
            var revStr = string.Empty;
            var lstWords = str.Split(' ').ToList();
            for(var i = (lstWords.Count - 1); i >= 0 ; i--)
            {
                revStr += lstWords[i];
                revStr += " ";
            }
            return revStr;
        }
    }
}
