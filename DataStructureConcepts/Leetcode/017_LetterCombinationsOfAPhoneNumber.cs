using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _017_LetterCombinationsOfAPhoneNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new LetterComboPhoneSolution().LetterCombinations("2345");
        }
    }

    public class LetterComboPhoneSolution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var lstCombo = new List<String>();
            var keyboard = new String[] { string.Empty, string.Empty, "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            LetterCombo(keyboard, lstCombo, digits, string.Empty);
            return lstCombo;
        }
        public void LetterCombo(String[] keyboard, List<String> lstCombo, String digits, String str)
          {
            if (str.Length == digits.Length)
            {
                lstCombo.Add(str);
                return;
            }
            var letters = keyboard[digits[str.Length] - '0'];
            for (int i = 0; i < letters.Length; ++i)
                LetterCombo(keyboard, lstCombo, digits, str + letters[i]);
        }
    }
}
