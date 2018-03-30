using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace DataStructureConcepts.Leetcode
{
    /*
     * Test Cases: 5/9
     */ 
    [TestClass]
    public class NQueens
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new NQueensSolution().SolveNQueens(4);
            var result = sol;
        }
    }
    public class NQueensSolution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var headList = new List<IList<string>>();
            var subList = new List<string>();

            if (n == 0 || n == 2)
                return headList;
            else if (n == 1)
            {
                subList.Add("Q");
                headList.Add(subList);
            }
            else
            {
                var row = 0;
                var col = 0;
                while (col < n)
                {
                    subList = NQueens(n, row, col);
                    if (subList.Count != 0 && !headList.Contains(subList))
                        headList.Add(subList);
                    ++col;
                }
            }
            return headList;
        }
        public List<string> NQueens(int n, int row, int col)
        {
            var subList = new List<string>();
            var visited = new int[n, n];
            var path = string.Empty;

            while (row < n && col < n)
            {
                visited[row, col] = 1;
                var oldRow = row;
                var oldCol = col;
                col = -1;

                // Vertical
                while (row < n - 1)
                {
                    ++row;
                    if (visited[row, oldCol] == 1)
                        continue;
                    else
                        visited[row, oldCol] = 9;
                }

                // Horizontal
                while (col < n - 1)
                {
                    ++col;
                    if (visited[oldRow, col] == 1)
                        continue;
                    else
                        visited[oldRow, col] = 9;
                }

                row = oldRow;
                col = oldCol;

                // Diagonal Left
                while (row < n - 1 && col > 0)
                {
                    ++row;
                    --col;
                    if (visited[row, col] == 1)
                        continue;
                    else
                        visited[row, col] = 9;
                }

                row = oldRow;
                col = oldCol;

                // Diagonal Right
                while (row < n - 1 && col < n - 1)
                {
                    ++row;
                    ++col;
                    if (visited[row, col] == 1)
                        continue;
                    else
                        visited[row, col] = 9;
                }

                row = row < n ? ++oldRow : row;
                col = 0;

                while (row != n && col != n)
                {
                    if(visited[row, col] == 9)
                        ++col;
                }
            }
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (visited[i, j] == 1)
                        path += "Q";
                    else
                        path += ".";
                }
                subList.Add(path);
                path = string.Empty;
            }
            return subList;
        }
    }
}
