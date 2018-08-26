using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class CompareListOfWordsWithSentence
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sentence = "Jack's and Jill's tall building has all the things jack and Jill been like likes.";
            var lstString = new List<string>();
            lstString.Add("is");
            lstString.Add("has");
            lstString.Add("the");
            lstString.Add("an");
            var sol = new CompareListOfWordsWithSentenceSolution().HighestFrequencyOfWord(lstString, sentence);
        }
    }
    public class CompareListOfWordsWithSentenceSolution
    {
        public List<WordCount> HighestFrequencyOfWord(List<string> lstString, string sentence)
        {
            sentence = sentence.Replace("!", "").Replace(",","").Replace(".","").Replace("'s","");
            var lstSentence = sentence.Split(' ').ToList();
            lstSentence = lstSentence.Select(x => x.ToLower()).ToList();
            var lstResult = new List<WordCount>();
            foreach(var str in lstSentence)
            {
                if(!lstString.Contains(str))
                {
                    if(lstResult.Select(x => x.word.Equals(str)).FirstOrDefault())
                        lstResult.LastOrDefault(x => x.word.Equals(str)).count++;
                    else
                    {
                        var wordObj = new WordCount();
                        wordObj.word = str;
                        wordObj.count++;
                        lstResult.Add(wordObj);
                    }
                }
            }
            return lstResult;
        }
    }
    public class WordCount
    {
        public int count;
        public string word;
        public WordCount()
        {
            this.count = 0;
            this.word = string.Empty;
        }
    }
}
