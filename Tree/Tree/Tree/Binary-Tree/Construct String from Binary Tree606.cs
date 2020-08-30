using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Construct_String_from_Binary_Tree
    {
        public static void Construct_String_from_Binary_Tree_Main()
        {
            //[1,2,3,null,4]
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(4);
            string t = Tree2str(root);
        }
        static string str;
        private static string Tree2str(TreeNode root)
        {
            if (root == null) return "";
            if (root.left == null && root.right == null)
            {
                return root.val+"";
            }
            if (root.right == null)
            {
                return root.val+"("+ Tree2str(root.left) + ")";
            }
            if (root.left == null)
            {
                return root.val + "(" + Tree2str(root.right) + ")";
            }
            return root.val + "(" + Tree2str(root.left)+")("+ Tree2str(root.right) + ")";
        }
    }
}
