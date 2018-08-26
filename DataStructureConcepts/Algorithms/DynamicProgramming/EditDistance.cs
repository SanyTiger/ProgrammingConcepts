using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DynamicProgramming
{
    /*
    * Test Cases: 548/1520
    */
    [TestClass]
    public class EditDistance
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class EditDistanceSolutionDynamic
    {
        public int MinDistance(string word1, string word2)
        {
            var count = 0;
            var m = word1.Length;
            var n = word2.Length;

            if (word1.Equals(word2))
                return count;
            else if (m == 0 || n == 0)
                return m != 0 ? m : n;
            else if (m == 1 && n == 1)
                return ++count;
            else
            {
                var arrDynamicCost = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (i == 0)
                            arrDynamicCost[i, j] = j;
                        else if (j == 0)
                            arrDynamicCost[i, j] = i;
                        else if (word1[i].Equals(word2[j]))
                            arrDynamicCost[i, j] = arrDynamicCost[i - 1, j - 1];
                        // Add      = d[i, j - 1]
                        // Delete   = d[i - 1, j]
                        // Replace  = d[i - 1, j - 1]
                        // Cost is assumed to be '1' for all operations
                        else
                            arrDynamicCost[i, j] = 1 + Math.Min(arrDynamicCost[i, j - 1],
                                (Math.Min(arrDynamicCost[i - 1, j], arrDynamicCost[i - 1, j - 1])));

                        /*
                        // Add      = d[i, j - 1], Cost = 1
                        // Delete   = d[i - 1, j], Cost = 3
                        // Replace  = d[i - 1, j - 1], Cost = 1
                        // Assume cost is given in an array along with the 2 string words as formal parameters.
                        // public int MinDistance(string word1, string word2, int[] arrCost)
                        // arrCost = {1, 3, 1}; // {add, del, rep}
                        else
                        {
                            var add = arrDynamicCost[i, j - 1];
                            var del = arrDynamicCost[i - 1, j];
                            var rep = arrDynamicCost[i - 1, j - 1];
                            var addCost = arrCost[0];
                            var delCost = arrCost[1];
                            var repCost = arrCost[2];

                            var min = Math.Min(add, (Math.Min(del, rep)));
                            var cost = min == add ? addCost : min == del ? delCost : min == rep ? repCost : 0;
                            arrDynamicCost[i, j] = cost + min;
                        }
                        */
                    }
                }
                count = arrDynamicCost[m - 1, n - 1];
            }
            return count;
        }
    }
}
