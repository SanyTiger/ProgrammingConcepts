using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    [TestClass]
    public class _24_SwapNodesInPairs
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new SwapNodesInPairs();
            ListNode l = new ListNode(1);
            l.next = new ListNode(2);
            l.next.next = new ListNode(3);
            sol.SwapPairs(l);
        }
    }
    public class SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            var subHead = new ListNode(0);
            var sub = subHead;
            while (head != null)
            {
                var temp = head.val;
                head = head.next;
                if (head != null)
                {
                    sub.next = new ListNode(head.val);
                    sub = sub.next;
                }
                sub.next = new ListNode(temp);
                sub = sub.next;
                head = head == null ? head : head.next;
            }
            return subHead.next;
        }
    }
}
