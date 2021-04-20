using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Convert_BST_to_Greater_Tree
    {
        public static void Convert_BST_to_Greater_Tree_Main()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(2);
            root.right = new TreeNode(13);
            TreeNode tree1 = ConvertBST(root);
            Console.ReadKey();
        }
        static int sum = 0;
        private static TreeNode ConvertBST(TreeNode root)
        {
            if (root != null)
            {
                ConvertBST(root.right);
                sum += root.val;
                root.val = sum;
                ConvertBST(root.left);
                return root;
            }
            return null;
        }
    }
}
