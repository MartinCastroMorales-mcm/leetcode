﻿namespace _235LowestCommonAnsestorOfABinarySearchTree;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    //Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }

    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) { 
            if(root.val < p.val ^ root.val < q.val) {
                return root;
            }
            if(root == p || root == q) {
                return root;
            }
            if(root.val < p.val && root.val < q.val) {
                return LowestCommonAncestor(root.right, p, q);
            }
            if(root.val > p.val && root.val > q.val) {
                return LowestCommonAncestor(root.left, p, q);
            }
            return null;
        }
    }
}
