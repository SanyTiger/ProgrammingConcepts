using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureConcepts.Data_Structures.Matrix.Problems
{

    /*
     * Java Solution
     * Working
     */
    /*
    import java.util.HashSet;

    public class Main
    {

        public int[][] distinct(int[][] arr)
        {
            int row = arr.length;
            int col = arr[0].length;
            HashSet<Integer> hashSet = new HashSet<>();

            if (row == 0 && col == 0)
            {
                return new int[row][col];
            }

            return getDistinct(arr, row, col, hashSet);
        }


        private int[][] convertMatrix(int[][] arr)
        {
            int firstMinimum = Integer.MAX_VALUE;
            int secondMinimum = Integer.MAX_VALUE;
            int col1 = 0;
            int col2 = 0;

            int temp;
            for (int i = 0; i < arr[0].length; i++) // col
            {
                temp = 0;
                int j;
                for (j = 0; j < arr.length; j++) // row
                {
                    temp += arr[j][i];
                }
                if (firstMinimum > temp)
                {
                    col2 = col1;
                    col1 = i;
                    secondMinimum = firstMinimum;
                    firstMinimum = temp;
                }
                else if (secondMinimum > temp)
                {
                    col2 = i;
                    secondMinimum = temp;
                }
            }
            if (secondMinimum >= 0)
            {
                return arr;
            }
            for (int i = 0; i < arr.length; i++)
            {
                arr[i][col1] *= -1;
                arr[i][col2] *= -1;
            }
            return convertMatrix(arr);
        }

        private int[][] getDistinct(int[][] arr, int row, int col, HashSet<Integer> hashSet)
        {
            if (hashSet.size() == row * 2)
            {
                for (int i = col; i >= col - 1; i--)
                {
                    for (int j = row; j >= 0; j--)
                    {
                        arr[j][i] = -arr[j][i];
                    }
                }
                row = 0;
                ++col;
                return getDistinct(arr, row, col, hashSet);
            }

            if (row == arr.length - 1)
            {
                row = 0;
            }

            if (col >= arr[0].length)
            {
                return arr;
            }

            if (!hashSet.contains(arr[row][col]))
            {
                hashSet.add(arr[row][col]);
                row++;
            }
            else
            {
                hashSet = new HashSet<>();
                row = 0;
                col++;
            }
            return getDistinct(arr, row, col, hashSet);
        }

        public int maxSum(int[][] arr)
        {
            arr = convertMatrix(arr);
            int sum = 0;
            for (int i = 0; i < arr.length; i++)
            {
                for (int j = 0; j < arr[0].length; j++)
                {
                    sum += arr[i][j];
                }
            }

            return sum;
        }


        public static void main(String[] args)
        {
            System.out.println("Hello World!");
            Main main = new Main();
            int[][] arr = new int[4][3];
            int count = -10;
            for (int i = 0; i < arr.length; i++)
            {
                for (int j = 0; j < arr[0].length; j++)
                {
                    arr[i][j] = count;
                    count++;
                    System.out.print(" " + arr[i][j]);
                }
                System.out.println();
            }
            System.out.println("" + main.maxSum(arr));
        }
    }

    */
    [TestClass]
    public class Visa
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class VisaSolution
    {
        public int[,] distinct(int[,] arr)
        {
            var row = arr.GetLength(0);
            var col = arr.GetLength(1);
            var hash = new HashSet<int>();

            // Check if matrix is not empty
            if (row == 0 || col == 0)
                return new int[row, col];

            return GetDistinct(arr, row, col, hash);
        }
        public int[,] GetDistinct(int[,] arr, int row, int col, HashSet<int> hash)
        {
            // if hash set has 2 columns worth numbers that signify it has 2 distinct column values
            // 2 column values = row_count * 2
            if(hash.Count == row * 2)
            {
                for(var i = col; i >= 0; --i)
                {
                    for (var j = row; j >= 0; --j)
                        arr[j, i] = -arr[j, i];
                }
                row = 0;
                ++col;
                return GetDistinct(arr, row, col, hash);
            }
            else
            {
                // checks if row count is lesser than array row count
                if (row == arr.GetLength(0) - 1)
                    row = 0;
                // checks if col count is lesser than array col count
                if (col == arr.GetLength(1) - 1)
                    return arr;
                // checks if hash set doesn't contain repeating values
                if (!hash.Contains(arr[row, col]))
                {
                    hash.Add(arr[row, col]);
                    ++row;
                }
                else
                {
                    hash = new HashSet<int>();
                    row = 0;
                    ++col;
                }
                return GetDistinct(arr, row, col, hash);
            }
        }

        public int maxSum(int[,] arr)
        {
            var sum = 0;
            for(var i = 0; i < arr.GetLength(0); i++)
            {
                for(var j = 0; j < arr.GetLength(1); j++)
                {
                    if (!(arr[i, j] < 0))
                        sum += arr[i, j];
                }
            }
            return sum;
        }
    }
}
