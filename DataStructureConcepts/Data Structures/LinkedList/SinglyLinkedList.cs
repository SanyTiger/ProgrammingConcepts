using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedList
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
        #region Linked List Insertion
        // General
        public static SingleLinkedList AddNumbersToEmptyList()
        {
            // Approach: 1/2
            var lstLink1 = new SingleLinkedList(1);
            var second = new SingleLinkedList(2);
            var third = new SingleLinkedList(3);
            var fourth = new SingleLinkedList(4);
            var fifth = new SingleLinkedList(5);
            lstLink1.next = second;
            second.next = third;
            third.next = fourth;
            fourth.next = fifth;

            // Approach: 2/2
            var lstLink2 = new SingleLinkedList(1);
            lstLink2.next = new SingleLinkedList(2);
            lstLink2.next.next = new SingleLinkedList(3);
            lstLink2.next.next.next = new SingleLinkedList(4);
            lstLink2.next.next.next.next = new SingleLinkedList(5);
            return lstLink1;
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
            var head = new SingleLinkedList(0);
            var sub = head;
            while (lstLink != null)
            {
                sub.next = lstLink;
                sub = sub.next;
                lstLink = lstLink.next;
            }
            sub.next = new SingleLinkedList(num);
            sub = sub.next;
            return head.next;
        }
        #endregion

        #region	Linked List Deletion (Deleting a given key)	
        
        #endregion
        #region	Linked List Deletion (Deleting a key at given position)	

        #endregion
        #region	Find Length of a Linked List (Iterative and Recursive)	

        #endregion
        #region	Search an element in a Linked List (Iterative and Recursive)	

        #endregion
        #region	Swap nodes in a linked list without swapping data	

        #endregion
        #region	Write a function to get Nth node in a Linked List	

        #endregion
        #region	Print the middle of a given linked list	

        #endregion
        #region	Nth node from the end of a Linked List	

        #endregion
        #region	Write a function to delete a Linked List	

        #endregion
        #region	Write a function that counts the number of times a given int occurs in a Linked List	

        #endregion
        #region	Reverse a linked list	

        #endregion
        #region	Detect loop in a linked list	

        #endregion
        #region	Merge two sorted linked lists	

        #endregion
        #region	Generic Linked List in C	

        #endregion
        #region	Function to check if a singly linked list is palindrome	

        #endregion
        #region	Intersection point of two Linked Lists.	

        #endregion
        #region	Recursive function to print reverse of a Linked List	

        #endregion
        #region	Remove duplicates from a sorted linked list	

        #endregion
        #region	Remove duplicates from an unsorted linked list	

        #endregion
        #region	Pairwise swap elements of a given linked list	

        #endregion
        #region	Move last element to front of a given Linked List	

        #endregion
        #region	Intersection of two Sorted Linked Lists	

        #endregion
        #region	Delete alternate nodes of a Linked List	

        #endregion
        #region	Alternating split of a given Singly Linked List	

        #endregion
        #region	Identical Linked Lists	

        #endregion
        #region	Merge Sort for Linked Lists	

        #endregion
        #region	Reverse a Linked List in groups of given size	

        #endregion
        #region	Reverse alternate K nodes in a Singly Linked List	

        #endregion
        #region	Delete nodes which have a greater value on right side	

        #endregion
        #region	Segregate even and odd nodes in a Linked List	

        #endregion
        #region	Detect and Remove Loop in a Linked List	

        #endregion
        #region	Add two numbers represented by linked lists | Set 1	

        #endregion
        #region	Delete a given node in Linked List under given constraints	

        #endregion
        #region	Union and Intersection of two Linked Lists	

        #endregion
        #region	Find a triplet from three linked lists with sum equal to a given number	

        #endregion
        #region	Rotate a Linked List	

        #endregion
        #region	Flattening a Linked List	

        #endregion
        #region	Add two numbers represented by linked lists | Set 2	

        #endregion
        #region	Sort a linked list of 0s, 1s and 2s	

        #endregion
        #region	Flatten a multilevel linked list	

        #endregion
        #region	Delete N nodes after M nodes of a linked list	

        #endregion
        #region	QuickSort on Singly Linked List	

        #endregion
        #region	Merge a linked list into another linked list at alternate positions	

        #endregion
        #region	Pairwise swap elements of a given linked list by changing links	

        #endregion
        #region	Given a linked list of line segments, remove middle points	

        #endregion
        #region	Clone a linked list with next and random pointer | Set 1	

        #endregion
        #region	Clone a linked list with next and random pointer | Set 2	

        #endregion
        #region	Insertion Sort for Singly Linked List	

        #endregion
        #region	Point to next higher value node in a linked list with an arbitrary pointer	

        #endregion
        #region	Rearrange a given linked list in-place.	

        #endregion
        #region	Sort a linked list that is sorted alternating ascending and descending orders.	

        #endregion
        #region	Select a Random Node from a Singly Linked List	

        #endregion
        #region	Merge two sorted linked lists such that merged list is in reverse order	

        #endregion
        #region	Compare two strings represented as linked lists	

        #endregion
        #region	Rearrange a linked list such that all even and odd positioned nodes are together	

        #endregion
        #region	Rearrange a Linked List in Zig-Zag fashion	

        #endregion
        #region	Add 1 to a number represented as linked list	

        #endregion
        #region	Point arbit pointer to greatest value right side node in a linked list	

        #endregion
        #region	Merge two sorted linked lists such that merged list is in reverse order	

        #endregion
        #region	Check if a linked list of strings forms a palindrome	

        #endregion
        #region	Sort linked list which is already sorted on absolute values	

        #endregion
        #region	Delete last occurrence of an item from linked list	

        #endregion
        #region	Delete a Linked List node at a given position	

        #endregion
        #region	Linked List in java	

        #endregion
        #region	In-place Merge two linked lists without changing links of first list	

        #endregion
        #region	Delete middle of linked list	

        #endregion
        #region	Merge K sorted linked lists | Set 1	

        #endregion
        #region	Decimal Equivalent of Binary Linked List	

        #endregion
        #region	Flatten a multi-level linked list | Set 2 (Depth wise)	

        #endregion
        #region	Rearrange a given list such that it consists of alternating minimum maximum elements	

        #endregion
        #region	Subtract Two Numbers represented as Linked Lists	

        #endregion
        #region	Find pair for given sum in a sorted singly linked without extra space	

        #endregion
        #region	Iteratively Reverse a linked list using only 2 pointers (An Interesting Method)	

        #endregion
        #region	Partitioning a linked list around a given value and keeping the original order	

        #endregion
        #region	Check linked list with a loop is palindrome or not	

        #endregion
        #region	Clone a linked list with next and random pointer in O(1) space	

        #endregion
        #region	Length of longest palindrome list in a linked list using O(1) extra space	

        #endregion
        #region	Adding two polynomials using Linked List	

        #endregion
        #region	Implementing Iterator pattern of a single Linked List	

        #endregion
        #region	Move all occurrences of an element to end in a linked list	

        #endregion
        #region	Remove all occurrences of duplicates from a sorted Linked List	

        #endregion
        #region	Remove every k-th node of the linked list	

        #endregion
        #region	Check whether the length of given linked list is Even or Odd	

        #endregion
        #region	Union and Intersection of two linked lists | Set-2 (Using Merge Sort)	

        #endregion
        #region	Multiply two numbers represented by Linked Lists	

        #endregion
        #region	Union and Intersection of two linked lists | Set-3 (Hashing)	

        #endregion
        #region	Find the sum of last n nodes of the given Linked List	

        #endregion
        #region	Count pairs from two linked lists whose sum is equal to a given value	

        #endregion
        #region	Merge k sorted linked lists | Set 2 (Using Min Heap)	

        #endregion
        #region	Recursive selection sort for singly linked list | Swapping node links	

        #endregion
        #region	Find length of loop in linked list	

        #endregion
        #region	Reverse a Linked List in groups of given size | Set 2	

        #endregion
        #region	Insert node into the middle of the linked list	

        #endregion
        #region	Merge two sorted lists (in-place)	

        #endregion
        #region	Sort a linked list of 0s, 1s and 2s by changing links	

        #endregion
        #region	Insert a node after the n-th node from the end	

        #endregion
        #region	Rotate Linked List block wise	

        #endregion
        #region	Count rotations in sorted and rotated linked list	

        #endregion
        #region	Make middle node head in a linked list	

        #endregion

    }
}
