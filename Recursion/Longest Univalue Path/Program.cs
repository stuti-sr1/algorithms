using System;

namespace Longest_Univalue_Path
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(1);
            //TreeNode root = new TreeNode(5);
            //root.left = new TreeNode(4);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(1);
            //root.right = new TreeNode(5);
            //root.right.right = new TreeNode(5);
            Console.WriteLine(LongestUnivaluePath(root));
            Console.ReadKey();
        }
        static TreeNode prev = null;
        static int count = 0;
        static int res = 0;
        public static int LongestUnivaluePath(TreeNode root)
        {
            if (root == null) return 0;
            if (root != null && root.left == null && root.right == null) return 0;
            InOrder(root);
            return res;
        }
        public static void InOrder(TreeNode root)
        {
            if (root == null) return;
            InOrder(root.left);
            if (prev != null)
            {
                if (prev.val == root.val) count++;
                else count = 0;

            }
            res = Math.Max(res, count);
            prev = root;
            InOrder(root.right);
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
