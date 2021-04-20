using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class MergeTwoBinaryTrees
    {
        public static void MergeTwoBinaryTreesMain()
        {
            // int[] root1 = { 1, 3, 2, 5 };
            //int[] root2 = { 2, 1, 3, null, 4, null, 7 };
            TreeNode root1 = new TreeNode(1);
            root1.left = new TreeNode(3);
            root1.right = new TreeNode(2);
            root1.left.left = new TreeNode(5);

            TreeNode root2 = new TreeNode(2);
            root2.left = new TreeNode(1);
            root2.right = new TreeNode(3);
            root2.left.right = new TreeNode(4);
            root2.right.right = new TreeNode(7);

            TreeNode result = MergeTwoBinaryTreesRecursive(root1, root2);
            Console.Write(result);
        }
        private static TreeNode MergeTwoBinaryTreesRecursive(TreeNode root1, TreeNode root2)
        {            
            if (root1 == null && root2 == null) return null;
            if (root1 != null && root2 == null) return root1;
            if (root1 == null && root2 != null) return root2;
            TreeNode treeNode = new TreeNode(root1.val + root2.val);
            treeNode.left = MergeTwoBinaryTreesRecursive(root1.left, root2.left);
            treeNode.right = MergeTwoBinaryTreesRecursive(root1.right, root2.right);
            return treeNode;
        }
    }
}
