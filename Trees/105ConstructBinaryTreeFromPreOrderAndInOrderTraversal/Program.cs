using System.Collections.Generic;

namespace _105ConstructBinaryTreeFromPreOrderAndInOrderTraversal;

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

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            TreeNode root;
            TreeNode padre = null;
            TreeNode leaf = root;
            Stack<TreeNode> stack = new();
            int j = 0;
            for (int i = 0; i < preorder.Length; i++)
            {
                leaf = new TreeNode();
                leaf.val = preorder[i];
                stack.Push(leaf);
                if (padre != null)
                {
                    if (padre.left == null)
                    {
                        padre.left = leaf;
                    }
                    else
                    {
                        padre.right = leaf;
                    }
                }
                if (i + 1 = preorder.Length)
                {
                    return root;
                }
                if (preorder[i] == inorder[j])
                {
                    while (stack.Peek() != inorder[j+1]) { 
                        j++;
                        padre = stack.Pop();
                    }
                }
            }
            return root;
        }
    }
}
