using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    [TestClass]
    public class BestPathAcrossMatrix
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arrMatrix = new int[4, 6] { { 1, 0, 0, 0, 0, 0 }, { 5, 4, -1, 3, 2, -1 }, { 5, 2, 1, 3, -1, -1 }, { 5, 2, 1, 3, 0, 1 } };
            var sol = new BestPathAcrossMatrixSolution().BestPathAcrossMatrix(arrMatrix);
            var s = sol;
        }
    }
    public class BestPathAcrossMatrixSolution
    {
        public int[,] BestPathAcrossMatrix(int[,] arrMatrix)
        {
            string path = Convert.ToString(arrMatrix[0, 0]);
            var row = 0;
            var col = 0;
            var visited = new int[arrMatrix.GetLength(0), arrMatrix.GetLength(1)];
            visited[0, 0] = arrMatrix[0, 0];

            while (true)
            {
                var down = row < arrMatrix.GetLength(0) - 1 ? arrMatrix[row + 1, col] : arrMatrix[row, col];
                var right = col < arrMatrix.GetLength(1) - 1 ? arrMatrix[row, col + 1] : arrMatrix[row, col];

                if (row == arrMatrix.GetLength(0) - 1 && col == arrMatrix.GetLength(1) - 1)
                    break;

                else if (down == -1 && right == -1)
                {
                    arrMatrix[row, col] = 9999;
                    arrMatrix[row - 1, col] = 9999;
                    row = row != 0 ? --row : arrMatrix.GetLength(0) - 1;
                    col = col != 0 ? --col : arrMatrix.GetLength(1) - 1;
                }

                // Check if tuple below current column != -1 when it's NOT the last column
                else if (down == -1 && col < arrMatrix.GetLength(1) - 1)
                { visited[row, col + 1] = right; ++col; }

                // Check if tuple below current column != -1 when it's the last column
                else if (down == -1 && col == arrMatrix.GetLength(1) - 1)
                { arrMatrix[row, col] = 9999; --col; }

                // Check if tuple beside current row != -1 when it's NOT the last row
                else if (right == -1 && row < arrMatrix.GetLength(0) - 1)
                { visited[row + 1, col] = down; ++row; }

                // Check if tuple beside current row != -1 when it's the last row
                else if (right == -1 && row == arrMatrix.GetLength(0) - 1)
                { arrMatrix[row, col] = 9999; --row; }

                // Check if down value is lesser than right value and the down value != -1
                else if (down < right && down != -1 && row < arrMatrix.GetLength(0) - 1)
                { visited[row + 1, col] = down; ++row; }

                // Check if right value is lesser than down value and the right value != -1
                else if (right < down && right != -1 && col < arrMatrix.GetLength(1) - 1)
                { visited[row, col + 1] = right; ++col; }

                // Check if right value != -1 when it's the last row
                else if (row == arrMatrix.GetLength(0) - 1 && right != -1)
                { visited[row, col + 1] = right; ++col; }

                // Check if down value != -1 when it's the last column
                else if (col == arrMatrix.GetLength(1) - 1 && down != -1)
                { visited[row + 1, col] = down; ++row; }
            }
            return visited;
        }
    }
}
