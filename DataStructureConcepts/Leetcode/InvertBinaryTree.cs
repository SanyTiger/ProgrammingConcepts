using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    [TestClass]
    public class InvertBinaryTree
    {
        [TestMethod]
        public void TestMethod1()
        {
            var head = new TreeNode(4);
            head.left = new TreeNode(2);
            head.right = new TreeNode(7);
            head.left.left = new TreeNode(1);
            head.left.right = new TreeNode(3);
            head.right.left = new TreeNode(6);
            head.right.right = new TreeNode(9);
            var sol = new InvertBinaryTreeSolution().InvertTree(head);
        }
    }
    public class InvertBinaryTreeSolution
    {

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;
            if (root.left == null && root.right == null)
                return root;

            var temp = root.left;
            root.left = root.right;
            root.right = temp;
            
            InvertTree(root.left);
            InvertTree(root.right);

            return root;
        }
    }
}
