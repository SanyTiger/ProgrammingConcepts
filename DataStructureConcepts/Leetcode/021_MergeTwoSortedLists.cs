using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _021_MergeTwoSortedLists
    {
        [TestMethod]
        public void TestMethod1()
        {
            var l1 = new ListNode(5);
            var l2 = new ListNode(1);
            l2.next = new ListNode(2);
            l2.next.next = new ListNode(4);
            var sol = new MergeTwoListsSolution().MergeTwoLists(l1, l2);
            var result = sol;
        }
    }
    public class MergeTwoListsSolution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var sub = head;
            if (l1 == null && l2 == null)
                return head.next;
            if (l1 != null && l2 == null)
            {
                if (l1 != null && l1.next == null)
                    return l1;
                else
                    return Merge(l1, null);
            }
            if (l1 == null && l2 != null)
            {
                if (l2 != null && l2.next == null)
                    return l2;
                else
                    return Merge(null, l2);
            }
            else
            {
                if (l1.next == null && l2.next == null)
                {
                    if (l1.val <= l2.val)
                    {
                        sub = new ListNode(l1.val);
                        sub.next = new ListNode(l2.val);
                    }
                    else
                    {
                        sub = new ListNode(l2.val);
                        sub.next = new ListNode(l1.val);
                    }
                    return sub;
                }
                else
                    return Merge(l1, l2);
            }
        }
        protected ListNode Merge(ListNode l1, ListNode l2)
       { 
            var head = new ListNode(0);
            var sub = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    sub.next = l1;
                    sub = sub.next;
                    l1 = l1.next;
                }
                else if (l1.val > l2.val)
                {
                    sub.next = l2;
                    sub = sub.next;
                    l2 = l2.next;
                }
            }
            while (l1 != null)
            {
                sub.next = l1;
                sub = sub.next;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                sub.next = l2;
                sub = sub.next;
                l2 = l2.next;
            }
            return head.next;
        }
    }
}
