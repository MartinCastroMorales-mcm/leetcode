using System.Collections.Generic;

namespace _1448CountGoodNodesInBinaryTree;

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
        public int GoodNodes(TreeNode root) { 
            if(root == null) {
                return 1;
            }
            int result = 1;
            int maxNumber = root.val;
            result += GoodNodes2(root.left, maxNumber);
            result += GoodNodes2(root.right, maxNumber);
            return result;
            
        }
        public int GoodNodes2(TreeNode root, int maxNumber) {
            int result = 0;
            if(root.val >= maxNumber) {
                result++;
                maxNumber = root.val;
            }
            result += GoodNodes2(root.left, maxNumber);
            result += GoodNodes2(root.right, maxNumber);
            return result;

        }
    }
}
