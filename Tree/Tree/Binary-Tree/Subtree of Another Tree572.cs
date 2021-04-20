using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Subtree_of_Another_Tree
    {
        public static void Subtree_of_Another_Tree_Main()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(4);
            root.right = new TreeNode(5);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(2);

            TreeNode root2 = new TreeNode(4);
            root2.left = new TreeNode(1);
            root2.right = new TreeNode(2);
            Console.Write(IsSubtree(root, root2));
        }

        // preorder store in string and then search index
        private static bool IsSubtree(TreeNode s, TreeNode t)
        {
            return Traversal(s, t);
        }
        private static bool equal(TreeNode s, TreeNode t)
        {
            if (s == null && t == null) return true;
            if (s == null || t == null) return false;
            if (s.val == t.val)
            {
                return equal(s.left, t.left) && equal(s.right, t.right);
            }
            else
                return false;
        }
        private static bool Traversal(TreeNode s, TreeNode t)
        {
            return (s != null && (equal(s, t) || Traversal(s.left, t) || Traversal(s.right, t)));
        }
    }
}
