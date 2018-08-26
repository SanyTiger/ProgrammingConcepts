using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class AddingBinaryNumbers
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new AddingBinaryNumbersSolution().Add("1001", "010");
            var result = sol;
        }
    }
    public class AddingBinaryNumbersSolution
    {
        public int Add(string a, string b)
        {
            var pos = 0;
            var carry = string.Empty;
            var sum = string.Empty;
            var len = a.Length > b.Length ? a.Length : b.Length;
            while(pos < len)
            {
                // Eg. 1001 & 010
                if (pos == a.Length)
                {
                    if (carry == "1" && b[pos] == '1')
                        sum = "10" + sum;
                    else
                        sum = "1" + sum;

                    carry = "0";
                }
                // Eg. 1001 & 010
                else if (pos == b.Length)
                {
                    if (carry == "1" && a[pos] == '1')
                        sum = "10" + sum;
                    else
                        sum = "1" + sum;

                    carry = "0";
                }
                // Eg. 111 & 011 
                else if (a[pos] == '1' && b[pos] == '1')
                {
                    if (carry == "1")
                        sum = "1" + sum;
                    else
                        sum = "0" + sum;

                    carry = "1";
                }
                // Eg. 111 & 011
                else if (a[pos] == '1' || b[pos] == '1')
                {
                    if (carry == "1")
                    {
                        sum = "0" + sum;
                        carry = "1";
                    }
                    else
                    {
                        sum = "1" + sum;
                        carry = "0";
                    }
                }
                else
                {
                    sum = carry + sum;
                    carry = "0";
                }
                ++pos;
            }
            if (!carry.Equals("0"))
                sum = carry + sum;
            return Convert.ToInt32(sum, 2);
        } 
    }
}
