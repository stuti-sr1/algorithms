using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class MaxHeight
    {
        public static void MaxHeightMain()
        {
            //Input: root = [3,9,20,null,null,15,7]
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            int result = MaxHeightRecursive(root);
            Console.Write(result);
        }

        private static int MaxHeightRecursive(TreeNode root)
        {
            if (root == null) return 0;
            return 1 + Math.Max(MaxHeightRecursive(root.left), MaxHeightRecursive(root.right));
        }
    }
}
