using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Leetcode
{
    [TestClass]
    public class ValidNumber
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new ValidNumberSolution();
            sol.IsNumber("ab");
        }
    }
    public class ValidNumberSolution
    {
        public bool IsNumber(string s)
        {
            return false;
            /*
            Valid Ones:
            1. One 'e' but preceeded and succeeded by numbers without space.
            2. One 'e' with single '+' but preceeded and succeeded by numbers without space.
            3. Single 'i' symbol succeeded by number without space.
            4. Single '.' preceeded and succeeded by numbers without space.
            5. Single '.' succeeded by numbers containing non-numbers like 'e' and '+' only without space.
            6. Single "!" symbol preceeded by number without space.
            */

            /*
            Invalid Ones:
            1. 'e'
                a. No numbers preceeding it.
                b. No numbers succeeding it.
                c. Multiple 'e's.
                d. Multiple '+'s.
                e. Single 'e' succeeded by numbers containing non-numbers like valid alphabets or special charaters.
                f. Single 'e' succeeded by numbers containing '.'.
            2. '+' not preceeded by single 'e'.
            3. 'i'
                a. Multiple 'i's.
                b. Single 'i' preceeded by number.
                c. Single 'i' succeeded by non-number like '!'.
                d. Single 'i' succeeded by numbers containing non-numbers like valid alphabets or special charaters.
                e. Single 'i' succeeded by numbers containing '.'.
            4. '.'
                a. Multiple '.'s.
                b. Single '.' succeeded by numbers containing non-numbers like valid alphabets or special charaters.
                c. 1c.
                d. 1d.
                e. 1e.
                f. 1f.
            5. 2.
            6. "!"
                a. Single "!" symbol succeeded by number.
                b. Single '!' succeeded by non-numbers like valid alphabets or special charaters.
                c. Single '!' preceeded by non-numbers like valid alphabets or special charaters.
                d. Single '!' preceeded by number containing any valid alphabets or special charaters.
            */

            /*
            Doubtful Ones:
            1. No "0" before dot, for example: ".1" instead of "0.1"
            2. Hexadecial, for example: "FFFFF" or "1AC".
            */

            // Check for invalid cases
            // Space between characters, invalid alphabets, invalid special characters.
        }
    }
}
