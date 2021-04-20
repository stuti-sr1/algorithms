using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Symmetric_Tree
    {
        public static void Symmetric_Tree_Main()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(2);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(3);
            Console.Write(IsSymmetric(root));
        }
        private static bool IsSymmetric(TreeNode root)
        {
            return IsSymmetric_Recursion(root, root);
        }

        private static bool IsSymmetric_Recursion(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            else if (root1 == null || root2 == null) return false;
            return (root1.val == root2.val) && IsSymmetric_Recursion(root1.left, root2.right) && IsSymmetric_Recursion(root1.right, root2.left);
            
        }
    }
}
