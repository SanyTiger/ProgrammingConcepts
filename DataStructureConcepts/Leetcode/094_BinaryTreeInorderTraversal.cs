using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Leetcode
{
    /*
     * All test cases passed
     */ 
    [TestClass]
    public class _094_BinaryTreeInorderTraversal
    {
        [TestMethod]
        public void TestMethod1()
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.left.left = new TreeNode(6);
            root.left.left.right = new TreeNode(7);
            root.left.right.right = new TreeNode(8);

            var sol = new BinaryTreeInorderTraversalSolution().InorderTraversal(root);
        }
    }
    public class BinaryTreeInorderTraversalSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            var queue = new List<TreeNode>();
            var completedNodes = new List<TreeNode>();
            var lst = new List<int>();

            if (root == null)
                return lst;
            if (root.left == null && root.right == null)
            {
                lst.Add(root.val);
                return lst;
            }
            if (root.left != null)
            {
                var tempLeftNode = root.left;
                AddToQueue(tempLeftNode, ref queue, completedNodes);
                GetListFromQueue(ref lst, queue, ref completedNodes);
                queue = new List<TreeNode>();
            }

            lst.Add(root.val);
            completedNodes.Add(root);

            if (root.right != null)
            {
                var tempRightNode = root.right;
                AddToQueue(tempRightNode, ref queue, completedNodes);
                GetListFromQueue(ref lst, queue, ref completedNodes);
                queue = new List<TreeNode>();
            }

            return lst;
        }
        public void AddToQueue(TreeNode root, ref List<TreeNode> queue, List<TreeNode> completedNodes)
        {
            while (root != null && !completedNodes.Contains(root))
            {
                queue.Add(root);
                root = root.left;
            }
        }
        public void GetListFromQueue(ref List<int> lst, List<TreeNode> queue, ref List<TreeNode> completedNodes)
        {
            while(queue.Count > 0)
            {
                var pos = queue.Count - 1;
                var tempLeafNode = queue[pos];
                lst.Add(tempLeafNode.val);
                completedNodes.Add(tempLeafNode);
                queue.RemoveAt(pos);

                if (tempLeafNode.left != null || tempLeafNode.right != null)
                {
                    AddToQueue(tempLeafNode.left, ref queue, completedNodes);
                    AddToQueue(tempLeafNode.right, ref queue, completedNodes);
                }
            }
        }
    }
}
