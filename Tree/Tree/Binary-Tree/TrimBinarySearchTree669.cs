using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class TrimBinarySearchTree
    {
        public static void TrimBinarySearchTree_Main()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(0);
            root.right = new TreeNode(4);
            root.left.right = new TreeNode(2);
            root.left.right.left = new TreeNode(1);
            root = TrimBST(root, 1, 3);
            Console.ReadKey();
        }
        private static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return null;
            else if (root.val <= R && root.val >= L)
            {
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
            }
            else if (root.val > R) return TrimBST(root.left, L, R);
            else if (root.val < L) return TrimBST(root.right, L, R);
            return root;
        }
    }
}
