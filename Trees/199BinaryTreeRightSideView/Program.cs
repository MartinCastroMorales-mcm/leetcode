namespace _199BinaryTreeRightSideView;
using System.Collections.Generic;

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
        
        
        public IList<int> RightSideView(TreeNode root) { 
            List<int> list = new();
            int level = 0;
            if(root == null) {
                return list;
            }
            if(level <= list.Count) {
                list.Add(root.val);
            }
            level++;
            RightView(root.right, level, list);
            RightView(root.left, level, list);
            return list;
        }

        public IList<int> RightView(TreeNode root, int level, List<int> list) {
            if(root == null) {
                return list;
            }
            Console.WriteLine("list.Count " + list.Count + " val: " + root.val + " level: " + level);
            if(level == list.Count) {
                list.Add(root.val);
            }
            level++;
            RightView(root.right, level, list);
            RightView(root.left, level, list);
            return list;
        }
    }
}
