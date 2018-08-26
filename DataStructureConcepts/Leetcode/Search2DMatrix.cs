using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    [TestClass]
    public class Search2DMatrix
    {
        [TestMethod]
        public void TestMethod1()
        {
            var arr = new int[2, 2] { { 1, 1 }, { 2, 2 } };
            var sol = new Search2DMatrixSolution().SearchMatrix(arr, 2);
            var result = sol;
        }
    }
    public class Search2DMatrixSolution
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            var row = matrix.GetLength(0);
            var col = matrix.GetLength(1);
            var isExist = false;

            if (row == 0 && col == 0)
                return isExist;
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < col; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        isExist = true;
                        return isExist;
                    }
                }
            }
            return isExist;
        }
    }
}
