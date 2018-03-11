using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class RecurringCharacter
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new RecurringCharacterSolution().GetCharacter("DBCABA");
        }
    }
    public class RecurringCharacterSolution
    {
        public char GetCharacter(string s)
        {
            var result = '\0';
            var lstList = new List<char>();
            if (s == string.Empty)
                return result;
            else
            {
                // O(n)
                s = s.ToUpper();
                var hash = new HashSet<char>();
                for(var i = 0; i < s.Length; i++)
                {
                    if (!hash.Contains(s[i]))
                        hash.Add(s[i]);
                    else
                    {
                        result = s[i];
                        break;
                    }
                }

                // O(n^2)
                s = s.ToUpper();
                for(var i = 0; i < s.Length; i++)
                {
                    if (!lstList.Contains(s[i]))
                        lstList.Add(s[i]);
                    else
                    {
                        result = s[i];
                        break;
                    }
                }
            }
            return result;
        }
    }
}
