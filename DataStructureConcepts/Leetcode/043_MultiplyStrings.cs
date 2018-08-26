using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * 153/311 test cases passed
     */
    [TestClass]
    public class _043_MultiplyStrings
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new MultiplyStringsSolution().Multiply("123456789", "987654321");
        }
    }
    public class MultiplyStringsSolution
    {
        public string Multiply(string num1, string num2)
        {

            if (num1.Equals(string.Empty) || num2.Equals(string.Empty))
                return string.Empty;

            var arrLength = num1.Length <= num2.Length ? num1.Length : num2.Length;
            var arr = new string[arrLength];
            var level = string.Empty;
            var carry = 0;
            var sum = string.Empty;
            var first = num1.Length >= num2.Length ? num1 : num2;
            var prev = first;
            var next = prev.Equals(num1) ? num2 : num1;

            while (!next.Equals(string.Empty))
            {
                while (!prev.Equals(string.Empty))
                {
                    var n1 = Convert.ToInt32(next[next.Length - 1] - '0');
                    var n2 = Convert.ToInt32(prev[prev.Length - 1] - '0');
                    var temp = (carry + (n1) * (n2)).ToString();
                    if (temp.Length == 2)
                    {
                        carry = Convert.ToInt32(temp[0] - '0');
                        temp = temp[1].ToString();
                    }
                    else
                        carry = 0;
                    temp = temp + sum;
                    sum = temp;
                    prev = prev.Substring(0, prev.Length - 1);
                }
                sum = carry != 0 ? Convert.ToString(carry) + sum : sum;
                sum += level;
                arr[level.Length] = sum;
                level += "0";
                carry = 0;
                sum = string.Empty;
                prev = first;
                next = next.Substring(0, next.Length - 1);
            }

            var result = 0.0;
            for (int i = 0; i < arr.Length; i++)
                result += Convert.ToDouble(arr[i]);
            sum = result.ToString("F99").TrimEnd('0').TrimEnd('.');
            return sum;
        }
    }
}