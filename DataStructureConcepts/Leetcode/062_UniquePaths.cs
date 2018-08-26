using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class _062_UniquePaths
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new UniquePathsSolution().UniquePaths(7, 3);
        }
    }
    public class UniquePathsSolution
    {
        public int UniquePaths(int m, int n)
        {
            // Recursive, but time exceeds at test case 38/64 for m = 19 and n = 13
            // Not effective for large numbers
            /*
            if (m == 1 || n == 1)
                return 1;

            return UniquePaths(m - 1, n) + UniquePaths(m, n - 1); // + UniquePaths(m - 1, n - 1);
            */

            if (m == 0 || n == 0)
                return 0;
            if (m == 1 || n == 1)
                return 1;
            if (m == 2 || n == 2)
                return 2;

            var path = new int[m, n];

            for (var i = 0; i < m; i++)
                path[i, 0] = 1;
            for (var j = 0; j < n; j++)
                path[0, j] = 1;

            for (var i = 1; i < m; i++)
            {
                for (var j = 1; j < n; j++)
                {
                    var row = path[i - 1, j];
                    var col = path[i, j - 1];
                    //var diagonal = path[i - 1, j - 1];
                    path[i, j] = row + col; //+ diagonal
                }
            }
            return path[m - 1, n - 1];
        }
    }
}
