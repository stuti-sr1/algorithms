using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Minimum_Distance_Between_BST_Nodes
    {
        public static void Minimum_Distance_Between_BST_Nodes_Main()
        {
            //[1,0,48,null,null,12,49,null,null,null,null]
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(0);
            root.right = new TreeNode(48);
            root.right.left = new TreeNode(12);
            root.right.right = new TreeNode(49);
            Console.Write(MinDiffInBST(root));
        }
        static int min = int.MaxValue;
        static int prev = -1;
        public static int MinDiffInBST(TreeNode root)
        {
            Helper(root);
            return min;
        }        
        private static void Helper(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Helper(root.left);
            if (prev != -1)
            {
                min = Math.Min(min, root.val - prev);
            }
            prev = root.val;
            Helper(root.right);
        }        
    }
}
