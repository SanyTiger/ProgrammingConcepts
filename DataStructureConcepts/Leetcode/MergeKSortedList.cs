using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * Test Case: 108/130
     */ 
    [TestClass]
    public class MergeKSortedList
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new MergeKSortedListSolution();
            var l1 = new ListNode();
            l1.next = new ListNode(5);
            l1.next.next = new ListNode(11);
            var l2 = new ListNode(1);
            l2.next = new ListNode(10);
            l2.next.next = new ListNode(6);
            var lst = new ListNode[2];
            lst[0] = l1;
            lst[1] = l2;
            var merge = sol.MergeKLists(lst);
            var result = merge;
        }
    }
    public class MergeKSortedListSolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var len = lists.Length;
            var head = new ListNode(0);
            var subHead = head;
            var pos = 0;

            if (len == 0)
                return head.next;
            if (len == 1 && lists[0] != null)
                return lists[pos];
            while (pos < len && lists[pos] == null)
                pos++;
            if (len == 2)
            {
                if (lists[0] != null && lists[1] == null)
                    return lists[0];
                else if (lists[0] == null && lists[1] != null)
                    return lists[1];
            }
            if (pos == len)
                return head.next;

            for (int i = pos + 1; i < len; i++)
            {
                if (lists[i] != null)
                {
                    lists[i] = MergeSort(lists[pos], lists[i]);
                    ++pos;
                }
                if (i == len - 1)
                    head.next = lists[i];
            }
            return head.next;
        }
        public ListNode MergeSort(ListNode prev, ListNode next)
        {
            var head = new ListNode(0);
            var sub = head;
            while (prev != null && next != null)
            {
                if (prev.val <= next.val)
                {
                    sub.next = new ListNode(prev.val);
                    prev = prev.next;
                }
                else if (prev.val > next.val)
                {
                    sub.next = new ListNode(next.val);
                    next = next.next;
                }
                sub = sub.next;
            }
            while (prev != null)
            {
                sub.next = new ListNode(prev.val);
                prev = prev.next;
                sub = sub.next;
            }
            while (next != null)
            {
                sub.next = new ListNode(next.val);
                next = next.next;
                sub = sub.next;
            }
            return head.next;
        } // endofmethod
    }
}
