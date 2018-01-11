using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace DataStructureConcepts.LinkedList
{
    /*
    You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

    You may assume the two numbers do not contain any leading zero, except the number 0 itself.

    Example

    Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
    Output: 7 -> 0 -> 8
    Explanation: 342 + 465 = 807.
    */

    [TestClass]
    public class AddTwoNumbersInLinkedList
    {
        [TestMethod]
        public void TestMethod1()
        {
            var lst = new LinkedList<int>();
        }
    }
    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
    public class AddTwoNumbersInLinkedListSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var var1 = 0.0;
            var var2 = 0.0;
            var i = 0;

            while (l1 != null && l2 != null)
            {
                var1 = l1 != null ? var1 + Math.Pow(10, i) * l1.val : var1;
                l1 = l1 != null ? l1.next : l1;
                var2 = l2 != null ? var2 + Math.Pow(10, i) * l2.val : var2;
                l2 = l2 != null ? l2.next : l2;
                i++;
                if (l1 == null && l2 == null)
                {
                    var sum = var1 + var2;
                    l1 = new ListNode((int)sum % 10);
                    l1.next = l1;
                    sum /= 10;
                }
            }
            return l1;
        }
    }
}
