using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.Leetcode
{
    /*
    You are given coins of different denominations and a total amount of money.Write a function to compute the number of combinations that make up that amount.You may assume that you have infinite number of each kind of coin.

    Note: You can assume that

    0 <= amount <= 5000
    1 <= coin <= 5000
    the number of coins is less than 500
    the answer is guaranteed to fit into signed 32-bit integer
    Example 1:


    Input: amount = 5, coins = [1, 2, 5]
    Output: 4
    Explanation: there are four ways to make up the amount:
    5=5
    5=2+2+1
    5=2+1+1+1
    5=1+1+1+1+1
    Example 2:


    Input: amount = 3, coins = [2]
    Output: 0
    Explanation: the amount of 3 cannot be made up just with coins of 2.
    Example 3:


    Input: amount = 10, coins = [10]
    Output: 1
    */

   [TestClass]
    public static class CoinChangeII
    {
        [TestMethod]
        public static void TestMethod1()
        {

        }
    }
    public static class CoinChangeIISolution
    {
        public static int Change(int amount, int[] coins)
        {
            var globalCount = 0;
            var globalAmount = amount;
            if (coins.Length < 2)
            {
                if (coins[0] < amount)
                    return 0;
                else if (coins[0] == amount)
                    return coins[0];
            }
            else
            {
                for (int i = 0; i < coins.Length; i++)
                {
                    amount = globalAmount;
                    for (int j = (i + 1); j < coins.Length; j++)
                    {
                        while (j < coins.Length && amount == 0)
                        {
                            if (amount / coins[i] == 0)
                            {
                                amount = amount - coins[i];
                                if (amount == 0)
                                    globalCount++;
                            }
                            else if (amount / coins[j] == 0)
                            {
                                amount = amount - coins[j];
                                if (amount == 0)
                                    globalCount++;
                            }
                            else if (amount - coins[i] == coins[j])
                            {

                            }
                        }
                    }

                }
            }
            return globalCount;
        }
    }
}
