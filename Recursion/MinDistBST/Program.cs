using System;

namespace MinDistBST
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(27);
            root.right = new TreeNode(34);
            root.right.right = new TreeNode(58);
            root.right.right.left = new TreeNode(50);
            root.right.right.left.left = new TreeNode(44);
            //[27,null,34,null,58,50,null,44,null,null,null]
            //[90,69,null,49,89,null,52,null,null,null,null]
            //TreeNode root = new TreeNode(90);
            //root.left = new TreeNode(69);
            //root.left.left = new TreeNode(49);
            //root.left.right = new TreeNode(89);
            //root.left.left.right = new TreeNode(52);

            //TreeNode root = new TreeNode(4);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(1);
            //root.left.right = new TreeNode(3);
            //root.right = new TreeNode(6);
            Console.WriteLine(MinDiffInBST(root));
            Console.ReadKey();
        }

        static TreeNode prev = null;
        static int diff = int.MaxValue;
        public static int MinDiffInBST(TreeNode root)
        {
            MinDiffInBSTDP(root);
            return diff;
        }
        public static int MinDiffInBSTDP(TreeNode root)
        {
            if (root == null) return diff;
            if (root.left != null)
            {
                MinDiffInBSTDP(root.left);
            }
            if (prev != null)
            {
                diff = Math.Min(diff, Math.Abs(root.val - prev.val));
            }
            prev = root;
            if (root.right != null)
            {
                MinDiffInBSTDP(root.right);
            }
            return diff;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; left = null; right = null; }
        }
    }
}