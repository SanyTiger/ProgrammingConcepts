using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Leetcode
{
    [TestClass]
    public class MergeTwoBinaryTrees
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t1 = new TreeNode(0);
            t1.left = new TreeNode(1);
            t1.left.left = new TreeNode(3);
            t1.left.left.left = new TreeNode(5);
            t1.left.right = new TreeNode(2);

            var t2 = new TreeNode(0);
            t2.left = new TreeNode(2);
            t2.left.left = new TreeNode(1);
            t2.left.left.right = new TreeNode(4);
            t2.left.right = new TreeNode(3);
            t2.left.right.right = new TreeNode(7);

            var sol = new MergeTwoBinaryTreesSolution().MergeTrees(t1.left, t2.left);
            var result = sol;
        }
    }
    public class MergeTwoBinaryTreesSolution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 == null || t2 == null)
                return t1 == null ? t2 : t1;
            t1.val += t2.val;

            t1.left = MergeTrees(t1.left, t2.left);
            t1.right = MergeTrees(t1.right, t2.right);

            return t1;
        }
    }
}
