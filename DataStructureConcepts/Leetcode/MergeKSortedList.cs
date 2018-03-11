using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace Leetcode
{
    [TestClass]
    public class MergeKSortedList
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new MergeKSortedListSolution();
            var l1 = new ListNode(-1);
            l1.next = new ListNode(1);
            //l1.next.next = new ListNode(11);

            var l2 = new ListNode(-3);
            l2.next = new ListNode(1);
            l2.next.next = new ListNode(4);

            var l3 = new ListNode(-2);
            l3.next = new ListNode(-1);
            l3.next.next = new ListNode(0);
            l3.next.next.next = new ListNode(1);

            var lst = new ListNode[3];
            lst[0] = l1;
            lst[1] = l2;
            lst[2] = l3;

            var merge = sol.MergeKLists(lst);
            var result = merge;
        }
    }
    public class MergeKSortedListSolution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            var hash = new List<ListNode>();
            var lstHead = new List<int>();
            var current = 0;
            var next = current + 1;
            var len = lists.Length;
            if (len == 0)
                return new ListNode(0).next;
            if(len == 1)
            {
                if(lists[0] == null)
                    return new ListNode(0).next;
                else
                    Merge(lists[0], null, ref lstHead);
            }
            else
            {
                foreach(var subList in lists)
                {
                    if (subList != null)
                        hash.Add(subList);
                }
                while(current < hash.Count && next < hash.Count)
                {
                    Merge(hash[current], hash[next], ref lstHead);
                    current = next + 1;
                    next = current + 1;
                }
                while(current < hash.Count)
                {
                    Merge(hash[current], null, ref lstHead);
                    ++current;
                }
                while (next < hash.Count)
                {
                    Merge(null, hash[next], ref lstHead);
                    ++next;
                }
                lstHead.Sort();
            }
            return AddToListNode(lstHead);
        }
        protected void Merge(ListNode l1, ListNode l2, ref List<int> head)
        {
            while(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    head.Add(l1.val);
                    l1 = l1.next;
                }
                else if(l1.val > l2.val)
                {
                    head.Add(l2.val);
                    l2 = l2.next;
                }
            }
            while(l1 != null)
            {
                head.Add(l1.val);
                l1 = l1.next;
            }
            while(l2 != null)
            {
                head.Add(l2.val);
                l2 = l2.next;
            }
        }
        protected ListNode AddToListNode(List<int> lst)
        {
            var head = new ListNode(0);
            var sub = head;
            foreach(var l in lst)
            {
                sub.next = new ListNode(l);
                sub = sub.next;
            }
            return head.next;
        }
    }
}
