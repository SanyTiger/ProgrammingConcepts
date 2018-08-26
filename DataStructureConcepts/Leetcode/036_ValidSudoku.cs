using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace DataStructureConcepts.Leetcode
{
    /*
     * 470/504 test cases passed
     * Coz haven't accounted for duplicates within box
     */
    [TestClass]
    public class _036_ValidSudoku
    {
        [TestMethod]
        public void TestMethod1()
        {
            var board = new char[9, 9]
            {
              {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
              {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
              {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
              {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
              {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
              {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
              {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
              {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
              { '.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };
            var sol = new ValidSudokuSolution().IsValidSudoku(board);
        }
    }
    public class ValidSudokuSolution
    {
        public bool IsValidSudoku(char[,] board)
        {
            var isTrue = true;
            var dicRow = new Dictionary<int, List<int>>();
            var dicCol = new Dictionary<int, List<int>>();

            var lstRow = new List<int>();
            var lstCol = new List<int>();
            if (!GetRowColDictionary(board, ref dicRow, ref dicCol))
                return false;
            else
            {
                for(var i = 0; i < board.GetLength(0); i++)
                {
                    dicCol.TryGetValue(i + 1, out lstCol);

                    for (var j = 0; j < board.GetLength(1); j++)
                    {
                        if (lstCol[j] == 0)
                            continue;

                        dicRow.TryGetValue(j + 1, out lstRow);
                        if (lstRow.Except(lstCol).Contains(lstCol[j]))
                            isTrue = false;
                    }
                }
            }
            return isTrue; 
        }
        protected bool GetRowColDictionary(char[,] board, ref Dictionary<int, List<int>> dRow, ref Dictionary<int, List<int>> dCol)
        {
            var lstRow = new List<int>();
            var lstCol = new List<int>();
            var isTrue = true;
            for(var i = 0; i < board.GetLength(0); i++)
            {
                for(var j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '.')
                        lstRow.Add(0);
                    else if (board[i, j] == 0)
                        continue;
                    else
                    {
                        if (!lstRow.Contains(board[i, j] - '0'))
                            lstRow.Add(Convert.ToInt32(board[i, j] - '0'));
                        else
                            isTrue = false;
                    }
                    if (board[j, i] == '.')
                        lstCol.Add(0);
                    else if (board[j, i] == 0)
                        continue;
                    else
                    {
                        if (!lstCol.Contains(board[j, i] - '0'))
                            lstCol.Add(Convert.ToInt32(board[j, i] - '0'));
                        else
                            isTrue = false;
                    }
                }
                dRow.Add(i + 1, lstRow);
                dCol.Add(i + 1, lstCol);
                lstRow = new List<int>();
                lstCol = new List<int>();

                if (!isTrue)
                    break;
            }
            return isTrue;
        }
    }
}
