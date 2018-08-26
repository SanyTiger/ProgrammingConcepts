using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Hackerrank
{
    /*
    Given an array of integers, calculate which fraction of its elements are positive, which fraction of its elements are negative, and which fraction of its elements are zeroes, respectively.Print the decimal value of each fraction on a new line.

    Note: This challenge introduces precision problems.The test cases are scaled to six decimal places, though answers with absolute error of up to are acceptable.

    Input Format

    The first line contains an integer, , denoting the size of the array.
    The second line contains  space-separated integers describing an array of numbers.

    Output Format

    You must print the following lines:

    A decimal representing of the fraction of positive numbers in the array compared to its size.
    A decimal representing of the fraction of negative numbers in the array compared to its size.
    A decimal representing of the fraction of zeroes in the array compared to its size.
    Sample Input

    6
    -4 3 -9 0 4 1         
    Sample Output

    0.500000
    0.333333
    0.166667
    Explanation

    There are 3 positive numbers, 2 negative numbers, and 1 zero in the array. 
    The respective fractions of positive numbers, negative numbers and zeroes are 3/6 = 0.50, 2/6 = 0.333 and 1/6 = 0.1667 respectively.
    */

    [TestClass]
    public static class PlusMinus
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class PlusMinusSolution
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(arr_temp, Int32.Parse);
            var positiveCount = 0.0;
            var negitiveCount = 0.0;
            var zeroCount = 0.0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == 0)
                    ++zeroCount;
                else if (a[i] > 0)
                    ++positiveCount;
                else
                    ++negitiveCount;
            }
            Console.WriteLine(positiveCount / n);
            Console.WriteLine(negitiveCount / n);
            Console.WriteLine(zeroCount / n);
        }
    }
}
