using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _006_ZigZagConversion
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new ZigZagConversionSolution().Convert("PAYPALISHIRING", 3);
            var result = sol;
        }
    }
    public class ZigZagConversionSolution
    {
        public string Convert(string s, int numRows)
        {
            var resultStr = string.Empty;
            var len = s.Length;
            var arrStr = new string[numRows];
            var row = 0;
            var isDown = false;

            if (numRows == 1)
                return s;

            for (int i = 0; i < len; ++i)
            {
                arrStr[row] += char.ToString(s[i]);
                if (row == numRows - 1)
                    isDown = false;
                else if (row == 0)
                    isDown = true;
                row = isDown == true ? row + 1 : row - 1;
            }
            for (int i = 0; i < numRows; ++i)
                resultStr += arrStr[i];
            return resultStr;
        }
    }
}
