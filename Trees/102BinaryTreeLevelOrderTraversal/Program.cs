using System.Collections;

namespace _102BinaryTreeLevelOrderTraversal;

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
        List<IList<int>> lista = new();
        public IList<IList<int>> LevelOrder(TreeNode root) { 
            if(root == null) {
                return this.lista;
            }
            int level = 0;
            List<int> listaNivel = new();
            listaNivel.Add(root.val);
            this.lista.Add(listaNivel);
            level++;
            InOrder(root.left, level);
            InOrder(root.right, level);
            return lista;
        }
        public void InOrder(TreeNode root, int level) {
            if(root == null) {
                return;
            }
            List<int> listaNivel;
            if(lista.Count <= level) {
                listaNivel = new List<int>();
                lista.Add(listaNivel);
            }else {
                listaNivel = (List<int>)lista[level];
            }
            level++;
            InOrder(root.left, level);
            listaNivel.Add(root.val);
            InOrder(root.right, level);
        }
    }
}
