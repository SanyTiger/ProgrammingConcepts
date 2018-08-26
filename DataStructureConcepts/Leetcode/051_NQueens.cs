using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Leetcode
{
    /*
     * Test Cases: 5/9
     */ 
    [TestClass]
    public class _051_NQueens
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new NQueensSolution().SolveNQueens(5);
            var result = sol;
        }
    }
    public class NQueensSolution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            var head = new List<IList<string>>();
            var sub = new List<string>();
            var str = string.Empty;
            var arr = new int[n, n];
            var row = 1;
            var col = 0;
            var noOfQPlaced = 1;

            if (n == 0)
                return head;
            if (n == 1)
            {
                sub.Add("Q");
                head.Add(sub);
                return head;
            }
            for (var i = 0; i < n; i++)
            {
                arr[0, i] = 1;
                IsolatePositionsInArray(ref arr, row, i);

                while (row < n && col < n)
                {
                    if (arr[row, col] == 0)
                    {
                        arr[row, col] = 1;
                        IsolatePositionsInArray(ref arr, ++row, col);
                        col = 0;
                        ++noOfQPlaced;
                        continue;
                    }
                    ++col;
                }
                if (noOfQPlaced == 4)
                {
                    for (var j = 0; j < arr.GetLength(0); j++)
                    {
                        for (var k = 0; k < arr.GetLength(1); k++)
                        {
                            if (arr[j, k] == -1)
                                str += ".";
                            else
                                str += "Q";
                        }
                        sub.Add(str);
                        str = string.Empty;
                    }
                    head.Add(sub);
                    sub = new List<string>();
                }
                row = 1;
                col = 0;
                noOfQPlaced = 1;
                arr = new int[n, n];
            }
            return head;
        }
        public void IsolatePositionsInArray(ref int[,] arr, int row, int col)
        {
            var d = col;

            // Isolate row
            for (var i = 0; i < arr.GetLength(1); i++)
            {
                if (i == col)
                    continue;
                arr[row - 1, i] = -1;
            }

            // Isolate Col
            for (var i = row; i < arr.GetLength(0); i++)
                arr[i, col] = -1;

            // Isolate Right Diagonal
            for (var i = row; i < arr.GetLength(1); i++)
            {
                if (d < arr.GetLength(1) - 1)
                    ++d;
                else
                    break;
                arr[i, d] = -1;
            }

            // Isolate Left Diagonal
            d = col;
            for (var i = row; i < arr.GetLength(1); i++)
            {
                if (d > 0)
                    --d;
                else
                    break;
                arr[i, d] = -1;
            }
        }
    }
}
