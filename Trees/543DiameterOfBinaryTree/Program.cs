namespace _543DiameterOfBinaryTree;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

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
        public int DiameterOfBinaryTree(TreeNode root)
        {
            return MaxDepth(root.left) + MaxDepth(root.right);
        }

        public int MaxDepth(TreeNode root)
        {
            int countLeft = 0;
            int countRight = 0;
            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            countLeft += MaxDepth(root.left);
            countRight += MaxDepth(root.right);

            if (countLeft > countRight)
            {
                return countLeft + 1;
            }
            else
            {
                return countRight + 1;
            }
        }
    }
}


