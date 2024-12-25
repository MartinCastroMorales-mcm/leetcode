namespace _226InvertBinaryTree;

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
        public TreeNode InvertTree(TreeNode root) { 
            if(root == null) {
                return null;
            }
            TreeNode oldLeft = InvertTree(root.left);
            TreeNode oldRight = InvertTree(root.right);
            root.left = oldRight;
            root.right = oldLeft;
            return root;
        }
        
    }
}
