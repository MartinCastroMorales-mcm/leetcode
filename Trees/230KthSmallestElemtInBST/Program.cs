using System.Collections.Generic;

namespace _230KthSmallestElemtInBST;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Solution sol = new();
        TreeNode leaf = new(2, null, null);
        TreeNode left = new(1, null, leaf);
        TreeNode right = new(4, null, null);
        TreeNode root = new(3, left, right);
        sol.KthSmallest(root, 1);
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
        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null)
            {
                return 0;
            }
            if (k == 0)
            {
                return root.val;
            }
            Stack<TreeNode> stack = new();
            TreeNode leaf = root;
            stack.Push(root);
            //Console.WriteLine("write left");
            //Console.WriteLine(root.val);
            while (true)
            {
                if (leaf.left == null)
                {
                    break;
                }
                //Console.WriteLine("write left");
                //Console.WriteLine(leaf.left.val);
                leaf = leaf.left;
                stack.Push(leaf);
            }
            while (stack.Count != 0)
            {
                //Console.WriteLine("pop");
                leaf = stack.Pop();
                Console.WriteLine(leaf.val);
                if(k == 1){
                    return leaf.val;
                }else {
                    k--;
                }
                
                if (leaf.right != null)
                {
                    stack.Push(leaf.right);
                    leaf = leaf.right;
                    while (true)
                    {
                        if (leaf.left == null)
                        {
                            break;
                        }
                        //Console.WriteLine("write left");
                        //Console.WriteLine(leaf.left.val);
                        leaf = leaf.left;
                        stack.Push(leaf);
                    }
                }
            }
            return 99999;
        }
    }
}
/*

public int KthSmallest(TreeNode root, int k) {
            
            if(root == null) {
                return -1;
            }
            if(k == 0) {
                return
            }
            Console.WriteLine("root: " + root.val + " k: " + k);
            if(root.left == null && root.right == null) {
                return -1;
            }
            k += KthSmallest(root.left, k);
            if(k == 0) {
                return root.val;
            }
            k += KthSmallest(root.right, k);
            if(k == 0) {
                return root.val;
            }
            return -1;
        }



*/
