using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class UnivaluedBinaryTree965
    {
        public static void UnivaluedBinaryTreeMain()
        {
            //Input: root = [3,9,20,null,null,15,7]
            TreeNode root = new TreeNode(0);
            //root.left = new TreeNode(1);
            //root.right = new TreeNode(1);
            //root.right.left = new TreeNode(1);
            //root.right.right = new TreeNode(1);
            bool result = UnivaluedBinaryTreeRecursive(root);
            Console.Write(result);
        }

        private static bool UnivaluedBinaryTreeRecursive(TreeNode root)
        {
            if (root == null) return true;
            bool left=root.left == null || (root.val==root.left.val && UnivaluedBinaryTreeRecursive(root.left));
            bool right=root.right == null || (root.val==root.right.val && UnivaluedBinaryTreeRecursive(root.right));
            return left && right;
        }
    }
}
