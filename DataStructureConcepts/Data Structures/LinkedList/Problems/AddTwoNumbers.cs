using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList
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
    public class AddTwoNumbers
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var sub = head;
            double num1 = GetReverseNumber(l1);
            double num2 = GetReverseNumber(l2);
            double sum = num1 + num2;
            var len = sum.ToString().Length;

            while (len != 0)
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
