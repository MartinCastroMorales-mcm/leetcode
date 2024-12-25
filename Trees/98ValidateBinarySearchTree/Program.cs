using System;
using System.Numerics;

namespace _98ValidateBinarySearchTree;

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
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            if(root.left != null) {
                if(root.left.val >= root.val) {
                    return false;
                }
            }
            if(root.right != null) {
                if(root.right.val <= root.val) {
                    return false;
                }
            }
            return (IsValidBST2(root.left, Int32.MinValue, root.val, false, true) && IsValidBST2(root.right, root.val, Int32.MaxValue, true, false));

        }
        public bool IsValidBST2(TreeNode root, int lowest, int highest, bool hasLow, bool hasHigh)
        {
            
            if (root == null)
            {
                return true;
            }
            int newLowest = lowest;
            int newHighest = highest;
            bool newHasLow = hasLow;
            bool newHasHigh = hasHigh;
            if(root.val >= newLowest) {
                newLowest = root.val;
                newHasLow = true;
            }
            if(root.val <= newHighest) {
                newHighest = root.val;
                newHasHigh = true;
            }
            Console.WriteLine("root.val: " + root.val + " lowest " + lowest + " highest " +  highest);
            if(root.left != null) {
                if(hasLow) {
                    if(root.left.val <= lowest) {
                    return false;
                    }
                }
                if(root.left.val >= root.val){
                    return false;
                }
            }
            if(root.right != null) {
                if(hasHigh) {
                    if(root.right.val >= highest) {
                    return false;
                    }
                }
                if(root.right.val <= root.val) {
                    return false;
                }
            }
            return (IsValidBST2(root.left, lowest, newHighest, newHasLow, newHasHigh) && IsValidBST2(root.right, newLowest, highest, newHasLow, newHasHigh));

        }
    }
}
