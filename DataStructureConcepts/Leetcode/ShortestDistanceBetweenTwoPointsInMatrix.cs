using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Leetcode
{
    [TestClass]
    public class ShortestDistanceBetweenTwoPointsInMatrix
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new Axon();
            var a = sol.findShortestRoute("T____;XXXX_;_____;_XXXX;____O");
        }
    }
    public class Axon
    {
        public class QItem
        {
            public int r;
            public int c;
            public int dist;
            public QItem(int x, int y, int z)
            {
                r = x;
                c = y;
                dist = z;
            }
        }

        // Complete the findShortestRoute function below.
        public int findShortestRoute(string grid)
        {
            var rowCount = 0;
            var colCount = 0;
            var matrix = getMatrixGrid(grid, ref rowCount, ref colCount);

            var source = new QItem(0, 0, 0);
            var visited = new bool[rowCount, colCount];
            for (var i = 0; i < rowCount; i++)
            {
                for (var j = 0; j < colCount; j++)
                {
                    if (matrix[i, j] == "X")
                        visited[i, j] = true;
                    else
                        visited[i, j] = false;

                    if (matrix[i, j] == "O")
                    {
                        source.r = i;
                        source.c = j;
                    }
                }
            }
            var queue = new Queue<QItem>();
            queue.Enqueue(source);
            visited[source.r, source.c] = true;
            while (queue.Count != 0)
            {
                QItem pQueue = queue.Peek();
                queue.Dequeue();
                if (matrix[pQueue.r, pQueue.c] == "T")
                    return pQueue.dist;
                if (pQueue.r - 1 >= 0 && visited[pQueue.r - 1, pQueue.c] == false)
                {
                    queue.Enqueue(new QItem(pQueue.r - 1, pQueue.c, pQueue.dist + 1));
                    visited[pQueue.r - 1, pQueue.c] = true;
                }
                if (pQueue.r + 1 < rowCount && visited[pQueue.r + 1, pQueue.c] == false)
                {
                    queue.Enqueue(new QItem(pQueue.r + 1, pQueue.c, pQueue.dist + 1));
                    visited[pQueue.r + 1, pQueue.c] = true;
                }
                if (pQueue.c - 1 >= 0 && visited[pQueue.r, pQueue.c - 1] == false)
                {
                    queue.Enqueue(new QItem(pQueue.r, pQueue.c - 1, pQueue.dist + 1));
                    visited[pQueue.r, pQueue.c - 1] = true;
                }
                if (pQueue.c + 1 < colCount && visited[pQueue.r, pQueue.c + 1] == false)
                {
                    queue.Enqueue(new QItem(pQueue.r, pQueue.c + 1, pQueue.dist + 1));
                    visited[pQueue.r, pQueue.c + 1] = true;
                }
            }

            return -1;
        }
        public static string[,] getMatrixGrid(string grid, ref int rowCount, ref int colCount)
        {
            var lstRows = grid.Split(';').ToList();
            rowCount = lstRows.Count;
            colCount = lstRows[0].Length;
            var matrix = new string[rowCount, colCount];
            PopulateMatrix(rowCount, colCount, ref matrix);
            var row = 0;
            var col = 0;
            foreach (var l in lstRows)
            {
                while (col < colCount)
                {
                    matrix[row, col] = Convert.ToString(l[col]);
                    ++col;
                }
                ++row;
                col = 0;
            }
            return matrix;
        }
        public static void PopulateMatrix(int r, int c, ref string[,] matrix)
        {
            for (var i = 0; i < r; i++)
            {
                for (var j = 0; j < c; j++)
                    matrix[i, j] = "_";
            }
        }
    }
}