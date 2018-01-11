using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

/*
 * Test Cases: 1560/1562
 * */

namespace DataStructureConcepts.Leetcode
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
            var sol = new AddTwoNumbersInLinkedListSolution();
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            sol.AddTwoNumbers(l1, l2);
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
            var head = new ListNode(0);
            var sub = head;
            double num1 = GetReverseNumber(l1);
            double num2 = GetReverseNumber(l2);
            double sum = num1 + num2;
            var len = sum.ToString().Length;

            while(len != 0)
            {
                sub.next = new ListNode(Convert.ToInt32(Math.Floor(sum % 10)));
                sub = sub.next;
                sum /= 10;
                len--;
            }
            return head.next;
        }
        public double GetReverseNumber(ListNode l1)
        {
            double num = 0;
            var i = 0;
            while (l1 != null)
            {
                num += Math.Pow(10, i) * l1.val;
                l1 = l1.next;
                i++;
            }
            return num;
        }
    }
}
