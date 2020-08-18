using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class InvertBinaryTree
    {
        public static void InvertBinaryTree_Main()
        {
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(7);
            root.right.left = new TreeNode(6);
            root.left.left = new TreeNode(1);
            root.right.right = new TreeNode(9);
            root.left.right = new TreeNode(3);
            InvertBinaryTree_Fun(root);
        }
        private static void InvertBinaryTree_Fun(TreeNode root1)
        {
            TreeNode head = InvertBinaryTree_Rec(root1);
        }
        private static TreeNode InvertBinaryTree_Rec(TreeNode root1)
        {
            if (root1 == null)
            {
                return null;
            }
            TreeNode left = InvertBinaryTree_Rec(root1.left);
            TreeNode right = InvertBinaryTree_Rec(root1.right);
            TreeNode root2 = new TreeNode(root1.val);
            root2.right = left;
            root2.left = right;
            return root2;
        }

        //private static TreeNode InvertBinaryTree_Rec(TreeNode root1, TreeNode root2)
        //{
        //    if (root1 == null)
        //    {
        //        root2 = null;
        //        return root2;
        //    }
        //    root2 = new TreeNode(root1.val);
        //    if (root1.left != null)
        //    {
        //        root2.right = new TreeNode();
        //        root2.right=InvertBinaryTree_Rec(root1.left, root2.right);
        //    }
        //    if (root1.right != null)
        //    {
        //        root2.left = new TreeNode();
        //        root2.left= InvertBinaryTree_Rec(root1.right, root2.left);
        //    }
        //    return root2;
        //}
    }
}