using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
    Given an integer, convert it to a roman numeral.

    Input is guaranteed to be within the range from 1 to 3999.
    */

    [TestClass]
    public static class IntToRoman
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class IntToRomanSolution
    {
        public static string IntToRoman(int num)
        {
            var roman = string.Empty;
            var len = num.ToString().Length;
            var m = num;
            var sum = 0;
            while (m > 0)
            {
                int r = m % 10;
                sum = 10 * sum + r;
                m = m / 10;
            }
            var n = sum;
            while (n > 0)
            {
                var r = n % 10;
                if (r == 0)
                {
                    n = n / 10;
                    len = len - 1;
                    continue;
                }
                else if (len == 1)
                    roman += singleRoman(n);
                else if (len == 2)
                {
                    if (r < 4)
                        roman += multipleXRoman(r);
                    else if (r == 4)
                        roman += "XL";
                    else if (r == 5)
                        roman += singleLRoman();
                    else if (r == 9)
                        roman += "XC";
                    else
                    {
                        roman += singleLRoman();
                        r = r - 5;
                        roman += multipleXRoman(r);
                    }
                }
                else if (len == 3)
                {
                    if (r < 4)
                        roman += multipleCRoman(r);
                    else if (r == 4)
                        roman += "CD";
                    else if (r == 5)
                        roman += singleDRoman();
                    else if (r == 9)
                        roman += "CM";
                    else
                    {
                        roman += singleDRoman();
                        r = r - 5;
                        roman += multipleCRoman(r);
                    }
                }
                else if (len == 4)
                    roman += multipleMRoman(r);
                n = n / 10;
                len = len - 1;
            }
            return roman;
        }
        public static string singleRoman(int n)
        {
            switch (n)
            {
                case 1: return "I"; 
                case 2: return "II"; 
                case 3: return "III"; 
                case 4: return "IV"; 
                case 5: return "V"; 
                case 6: return "VI";
                case 7: return "VII"; 
                case 8: return "VIII";
                case 9: return "IX"; 
                default: return "";  
            }
        }
        public static string multipleXRoman(int n)
        {
            var mul = string.Empty;
            while (n > 0)
            {
                mul += "X";
                n = n - 1;
            }
            return mul;
        }
        public static string singleLRoman()
        {
            return "L";
        }
        public static string multipleCRoman(int n)
        {
            var mul = string.Empty;
            while (n > 0)
            {
                mul += "C";
                n = n - 1;
            }
            return mul;
        }
        public static string singleDRoman()
        {
            return "D";
        }
        public static string multipleMRoman(int n)
        {
            var mul = string.Empty;
            while (n > 0)
            {
                mul += "M";
                n = n - 1;
            }
            return mul;
        }
    }
}
