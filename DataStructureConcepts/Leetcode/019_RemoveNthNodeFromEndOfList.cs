using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * 194/208 test cases passed
     */
    [TestClass]
    public class _019_RemoveNthNodeFromEndOfList
    {
        [TestMethod]
        public void TestMethod1()
        {
            var node = new ListNode(1);
            node.next = new ListNode(2);
            var sol = new RemoveNthFromEndSolution().RemoveNthFromEnd(node, 1);
        }
    }
    public class RemoveNthFromEndSolution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            var sub = new ListNode(0);
            var s = sub;
            var copyHead = head;
            var len = 0;

            while (copyHead != null)
            {
                ++len;
                copyHead = copyHead.next;
            }

            if (n == 1 && len == 1)
                return sub.next;
            if (n == 1 && len == 2)
                return new ListNode(head.val);

            var diff = len - n;
            len = 0;
            while (head != null)
            {
                if (diff == len)
                {
                    ++len;
                    head = head.next;
                    continue;
                }
                else
                    ++len;
                s.next = head;
                s = s.next;
                head = head.next;
            }
            return sub.next;
        }
    }
}
