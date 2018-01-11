using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Recursion
{
    /*
    Consider a staircase of size n=4:

       #
      ##
     ###
    ####

    Observe that its base and height are both equal to, and the image is drawn using # symbols and spaces. The last line is not preceded by any spaces.

    Write a program that prints a staircase of size.

    Input Format

    A single integer, , denoting the size of the staircase.

    Output Format

    Print a staircase of size  using # symbols and spaces.

    Note: The last line must have spaces in it.

    Sample Input

    6 
    Sample Output

    #
    ##
    ###
    ####
    #####
    ######
        Explanation

    The staircase is right-aligned, composed of # symbols and spaces, and has a height and width of n=6.
    */

    [TestClass]
    public static class Staircase
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class StaircaseSolution
    {
        public static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            stairs(n, (n - 1));
        }
        public static void stairs(int last, int secondLast)
        {
            if (secondLast >= 0)
            {
                var diff = last - secondLast;
                var space = secondLast;
                while (space > 0)
                {
                    Console.Write(" ");
                    --space;
                }
                while (diff > 0)
                {
                    Console.Write("#");
                    --diff;
                }
                Console.Write("\n");
                stairs(last, (secondLast - 1));
            }
        }
    }
}
