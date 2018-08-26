using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _025_ReverseNodesInKGroup
    {
        [TestMethod]
        public void TestMethod1()
        {
            var head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            //head.next.next.next.next.next = new ListNode(6);
            var sol = new ReverseNodesInKGroupSolution().ReverseKGroup(head, 3);
        }
    }
    public class ReverseNodesInKGroupAlternateSolution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            int count = 0;
            ListNode curr = head;
            while (curr != null && count != k)
            {
                curr = curr.next;
                count++;
            }
            if (count == k)
            {
                curr = ReverseKGroup(curr, k);
                while (count-- > 0)
                {
                    ListNode temp = head.next;
                    head.next = curr;
                    curr = head;
                    head = temp;
                }
                head = curr;
            }
            return head;
        }
    }
    public class ReverseNodesInKGroupSolution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var n = GetNumberOfValuesInLinkedList(head);
            if (k == 0)
                return head;
            if (head == null || head.next == null)
                return head;
            if (n < k)
                return head;
            else
            {
                var sub = head;
                var dicHead = new Dictionary<int, List<int>>();
                var lstInt = new List<int>();
                var pos = 0;
                var subK = k - 1;
                var noOfIterations = n / k;
                while (noOfIterations > 0)
                {
                    if(subK != -1)
                    {
                        lstInt.Add(sub.val);
                        sub = sub.next;
                        --subK;
                    }
                    else
                    {
                        lstInt.Reverse();
                        dicHead.Add(pos, lstInt);
                        lstInt = new List<int>();
                        ++pos;
                        subK = k - 1;
                        --noOfIterations;
                    }
                }
                while(sub != null)
                {
                    lstInt.Add(sub.val);
                    sub = sub.next;
                }
                dicHead.Add(pos, lstInt);

                head = new ListNode(0);
                sub = head;
                foreach(var dic in dicHead)
                {
                    foreach(var val in dic.Value)
                    {
                        sub.next = new ListNode(val);
                        sub = sub.next;
                    }
                }
            }
            return head.next;
        }
        public int GetNumberOfValuesInLinkedList(ListNode head)
        {
            var sub = head;
            var count = 0;
            while (sub != null)
            {
                ++count;
                sub = sub.next;
            }
            return count;
        }
    }
}
