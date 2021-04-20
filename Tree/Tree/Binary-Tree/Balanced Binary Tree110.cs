using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Balanced_Binary_Tree
    {
        public static void Balanced_Binary_Tree_Main()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(3);
            root.left.left.left = new TreeNode(4);
            root.left.left.right = new TreeNode(4);

            //TreeNode root = new TreeNode(3);
            //root.left = new TreeNode(9);
            //root.right = new TreeNode(20);
            //root.right.left = new TreeNode(15);
            //root.right.right = new TreeNode(7);
            Console.Write(IsBalanced(root));
            TreeNode root1 = new TreeNode(1);
            Console.Write(IsBalanced(root1));
        }

        static int diff = int.MinValue;
        public static bool IsBalanced(TreeNode root)
        {
            diff = int.MinValue;
            if (root == null) return true;
            int t = IsBalanced_Recursive(root);
            return diff > 1 ? false : true;
        }

        private static int IsBalanced_Recursive(TreeNode root)
        {
            if (root == null) return 0;
            int L = IsBalanced_Recursive(root.left);
            int R = IsBalanced_Recursive(root.right);
            diff = Math.Max(diff, Math.Abs(L - R));
            return 1 + Math.Max(L, R);
        }
    }
}
