using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _002_AddTwoNumbers
    {
        [TestMethod]
        public void TestMethod1()
        {
            var sol = new AddTwoNumbersSolution();
            var l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);
            var l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);
            sol.AddTwoNumbers(l1, l2);
        }
    }
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var sub = head;
            var sum = 0;
            var carry = 0;
            if (l1 == null && l2 == null)
                return head.next;
            while (l1 != null || l2 != null || carry != 0)
            {
                sum = carry;
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                carry = sum / 10;
                sum = sum % 10;
                sub.next = new ListNode(sum);
                sub = sub.next;
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
            if (carry != 0)
            {
                sub.next = new ListNode(carry);
                sub = sub.next;
            }
            return head.next;
        }
    }
}
