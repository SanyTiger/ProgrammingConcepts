using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{

    /*
     * 
        void PrintPattern(integer patternSize)
        {
              . . .
        }
 
        The function should print an alternating square pattern using the letters 'X' and 'O'.  The height of the pattern will be the function’s only parameter.  The pattern should be sized appropriately for any valid value of the parameter.  You can be guaranteed that the parameter will be a positive ODD number.  An optimal solution would not use a buffer to store the pattern.
 
        Example Output:
 
 
        patternSize = 1
        X
 
        patternSize = 3
        OOO
        OXO
        OOO
 
        patternSize = 5
        XXXXX
        XOOOX
        XOXOX
        XOOOX
        XXXXX
 
        patternSize = 7
        OOOOOOO
        OXXXXXO
        OXOOOXO
        OXOXOXO
        OXOOOXO
        OXXXXXO
        OOOOOOO

     */
    [TestClass]
    public class Adapt
    {
        [TestMethod]
        public void TestMethod1()
        {
            new AdaptSolution().PrintPattern(3);
        }
    }
    public class AdaptSolution
    {
        public void PrintPattern(int patternSize)
        {
            if (patternSize == 1)
                Console.WriteLine("X");
            else
            {
                var arr = new string[patternSize, patternSize];
                var center = patternSize / 2;
                var hop = 0;
                var start = 0;
                var end = 2;
                var size = patternSize - 1;
                size -= 2;
                while (size != 0)
                {
                    ++hop;
                    size -= 2;
                }
                GetPattern(start + hop, end + hop, arr, center, "O");
                var row = arr.GetLength(0) - 1;
                var col = arr.GetLength(1) - 1;
                for (int i = 0; i <= row; i++)
                {
                    for (int j = 0; j <= col; j++)
                    {
                        Console.Write(arr[i, j]);
                        Console.Write("\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        public void GetPattern(int start, int end, string[,] arr, int center, string symbol)
        {
            if (start < 0)
                return;
            for (var i = start; i <= end; i++)
            {
                for (var j = start; j <= end; j++)
                {
                    if (i == center && j == center)
                        arr[i, j] = "X";
                    else if (arr[i, j] == null)
                        arr[i, j] = symbol;
                }
            }
            if (symbol.Equals("X"))
                symbol = "O";
            else
                symbol = "X";
            GetPattern(--start, ++end, arr, center, symbol);
        }
    }
}
