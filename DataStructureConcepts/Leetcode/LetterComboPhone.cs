using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
/*
* Test Cases: 12 / 25
*/
namespace Leetcode
{
    [TestClass]
    public class LetterComboPhone
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = LetterComboPhoneSolution.LetterCombinations("2");
        }
    }
    public static class LetterComboPhoneSolution
    {
        public static IList<string> LetterCombinations(string digits)
        {
            IList<string> lstLetter = new List<string>();
            var arrLetter = new string[10];
            for (int i = 0; i < digits.Length; i++)
            {
                char temp = digits[i];
                arrLetter[i] = GetLetter(temp - 48);
            }
            
            if (digits.Length == 1)
            {
                var letter = arrLetter[0];
                for (int i = 0; i < letter.Length; i++)
                    lstLetter.Add(string.Concat(letter[i], ""));
            }
            else
            {
                var initial = 0;
                var increment = initial + 1;
                while (arrLetter[increment] != null)
                {
                    var letter = arrLetter[initial];
                    var secondLetter = arrLetter[increment];

                    for (int j = 0; j < letter.Length; j++)
                    {
                        for (int k = 0; k < secondLetter.Length; k++)
                            lstLetter.Add(string.Concat(letter[j], secondLetter[k]));
                    }
                    if (increment < arrLetter.Length)
                        increment++;
                    else if (initial < arrLetter.Length)
                    {
                        initial++;
                        increment = initial + 1;
                    }
                    else
                        break;
                }
            }

            return lstLetter;
        }
        public static string GetLetter(int num)
        {
            switch (num)
            {
                case 2: return "abc";
                case 3: return "def";
                case 4: return "ghi";
                case 5: return "jkl";
                case 6: return "mno";
                case 7: return "pqrs";
                case 8: return "tuv";
                case 9: return "wxyz";
                default: return string.Empty;
            }
        }
    }
}
