using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;

namespace Leetcode
{
    [TestClass]
    public class StringToInt
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new StringToIntSolution();
            var sum = sol.MyAtoi("-2147483648");
            var result = sum;
        }
    }
    public class StringToIntSolution
    {
        public int MyAtoi(string str)
        {
            var isPos = false;
            var isNeg = false;
            var isSum = false;
            var sum = 0.0;

            for (int i = 0; i < str.Length; i++)
            {
                if (!Regex.IsMatch(char.ToString(str[i]), "^[0-9]"))
                {
                    if (isSum)
                        break;
                    if (Regex.IsMatch(char.ToString(str[i]), "^[a-zA-Z]"))
                        break;
                    if (str[i] == '-')
                    {
                        if (isPos)
                            break;
                        else
                            isNeg = true;
                        isSum = true;
                    }
                    if (str[i] == '+')
                    {
                        if (isNeg)
                            break;
                        else
                            isPos = true;
                        isSum = true;
                    }
                }
                else
                {
                    sum = sum * 10 + Convert.ToDouble(char.ToString(str[i]));
                    isSum = true;
                }
            }
            sum = isNeg == true ? -sum : sum;
            return sum > Int32.MaxValue ? Int32.MaxValue : sum < Int32.MinValue ? Int32.MinValue : Convert.ToInt32(sum);
        }
    }
}
