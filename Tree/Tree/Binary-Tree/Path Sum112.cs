using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Path_Sum
    {
        public static void Path_Sum_Main()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.right = new TreeNode(8);
            root.left.left = new TreeNode(11);
            root.left.left.left = new TreeNode(7);
            root.left.left.right = new TreeNode(2);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.right = new TreeNode(1);
            Console.Write(HasPathSum(root, 22));
            TreeNode root1 = new TreeNode(-2);
            root1.right = new TreeNode(-3);
            Console.Write(HasPathSum(root1, -5));
        }
        private static bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            sum = sum - root.val;
            if (root.left == null && root.right == null)
            {
                return (sum == 0);
            }
            return HasPathSum(root.left, sum) || HasPathSum(root.right, sum);
        }
    }
}
