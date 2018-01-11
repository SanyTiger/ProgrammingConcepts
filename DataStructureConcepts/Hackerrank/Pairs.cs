using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Hackerrank
{
    /*
    Output Format

    An integer that tells the number of pairs of integers whose difference is K.

    Sample Input

    5 2  
    1 5 3 4 2  
    Sample Output

    3
    Explanation

    There are 3 pairs of integers in the set with a difference of 2.
    */

    [TestClass]
    public static class Pairs
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class PairsSolution
    {
        /* Head ends here */
        public static int pairs(int[] a, int k)
        {
            var count = 0;
            var n = a.Length;
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;
            else
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = (n - 1); j > i; j--)
                    {
                        if (a[i] - a[j] > 0)
                        {
                            if (a[i] - a[j] == k)
                            {
                                count++;
                                continue;
                            }
                        }
                        else if (a[j] - a[i] > 0)
                        {
                            if (a[j] - a[i] == k)
                            {
                                count++;
                                continue;
                            }

                        }
                    }
                }
            }
            return count;
        }
        /* Tail starts here */
        public static void Main(String[] args)
        {
            int res;

            String line = Console.ReadLine();
            String[] line_split = line.Split(' ');
            int _a_size = Convert.ToInt32(line_split[0]);
            int _k = Convert.ToInt32(line_split[1]);
            int[] _a = new int[_a_size];
            int _a_item;
            String move = Console.ReadLine();
            String[] move_split = move.Split(' ');
            for (int _a_i = 0; _a_i < move_split.Length; _a_i++)
            {
                _a_item = Convert.ToInt32(move_split[_a_i]);
                _a[_a_i] = _a_item;
            }

            res = pairs(_a, _k);
            Console.WriteLine(res);

        }
    }
}
