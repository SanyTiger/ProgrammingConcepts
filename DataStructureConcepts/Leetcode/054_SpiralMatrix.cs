using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _054_SpiralMatrix
    {
        [TestMethod]
        public void TestMethod1()
        {
            var matrix = new int[3, 3]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            var sol = new SpiralMatrixSolution().SpiralOrder(matrix);
        }
    }
    public class SpiralMatrixSolution
    {
        public IList<int> SpiralOrder(int[,] matrix)
        {
            var lst = new List<int>();
            var rowMin = 0;
            var colMin = -1;
            var isRightDirection = true;
            var rowMax = matrix.GetLength(0);
            var colMax = matrix.GetLength(1);
            var row = 0;
            var col = 0;

            if (matrix.Length == 0)
            {
                lst.Add(0);
                return lst;
            }
            while (lst.Count != matrix.GetLength(0) * matrix.GetLength(1))
            {
                var r = rowMin;
                var c = colMin;
                if (isRightDirection)
                {
                    r = rowMax;
                    c = colMax;
                }
                while (col != c)
                {
                    lst.Add(matrix[row, col]);
                    col = isRightDirection == true ? ++col : --col; // increment till we reach last column + 1
                }
                col = isRightDirection == true ? --col : ++col;     // If reached last column + 1, sub 1
                row = isRightDirection == true ? ++row : --row;     
                while (row != r)
                {
                    lst.Add(matrix[row, col]);
                    row = isRightDirection == true ? ++row : --row;
                }
                col = isRightDirection == true ? --col : ++col;     // if reached first col - 1, add 1
                row = isRightDirection == true ? --row : ++row;     
                if (isRightDirection)
                {
                    isRightDirection = false;
                    --rowMax;
                    --colMax;
                }
                else
                {
                    isRightDirection = true;
                    ++rowMin;
                    ++colMin;
                }
            }
            return lst;
        }
    }
}
