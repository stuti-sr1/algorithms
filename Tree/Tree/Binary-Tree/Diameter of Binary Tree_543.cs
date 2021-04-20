using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Diameter_of_Binary_Tree
    {
        public static void Diameter_of_Binary_Tree_Main()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            Console.Write(DiameterOfBinaryTree(root));
        }
        static int ans = 0;
        private static int DiameterOfBinaryTree(TreeNode root)
        {
            if (root == null) return 0;
            int ht = DiameterOfBinaryTree_Recursion(root);
            return ans-1;
        }
        private static int DiameterOfBinaryTree_Recursion(TreeNode root)
        {
            if (root == null) return 0;
            int L = DiameterOfBinaryTree_Recursion(root.left);
            int R = DiameterOfBinaryTree_Recursion(root.right);
            ans = Math.Max((L + R + 1), ans);
            return 1 + Math.Max(L, R);
        }
    }
}
