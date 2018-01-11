using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructureConcepts.LinkedList
{
    [TestClass]
    public class SinglyLinkedList
    {
        [TestMethod]
        public void TestMethod1()
        {
            var lstLinked = SinglyLinkedListSolution.AddNumbersToEmptyList();
            lstLinked = SinglyLinkedListSolution.AddNumberToLast(lstLinked, 6);
            lstLinked = SinglyLinkedListSolution.AddNumberToFirst(lstLinked, 0);
        }
    }
    internal class SingleLinkedList
    {
        public int value;
        public SingleLinkedList next;
        public SingleLinkedList(int x) { value = x; next = null; }
    }
    internal class SinglyLinkedListSolution
    {
        // Push numbers to an empty linked list
        public static SingleLinkedList AddNumbersToEmptyList()
        {
            var lstLink = new SingleLinkedList(1);
            var second = new SingleLinkedList(2);
            var third = new SingleLinkedList(3);
            var fourth = new SingleLinkedList(4);
            var fifth = new SingleLinkedList(5);

            lstLink.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = fifth;
            return lstLink;
        }

        // Add number to starting of linkedlist
        public static SingleLinkedList AddNumberToFirst(SingleLinkedList lstLink, int num)
        {
            var tempLink = lstLink;
            var newElement = new SingleLinkedList(num);
            lstLink = newElement;
            newElement.next = tempLink;
            return newElement;
        }
        // Add number to end of linkedlist
        public static SingleLinkedList AddNumberToLast(SingleLinkedList lstLink, int num)
        {
            return lstLink;
        }
    }
}
