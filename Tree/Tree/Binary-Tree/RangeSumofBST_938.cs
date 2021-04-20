using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public static class RangeSumofBST
    {
        public static void RangeSumofBSTMain()
        {
           // int[] root = { 10, 5, 15, 3, 7, null, 18 };
            int L = 7, R = 15;
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.right = new TreeNode(15);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.right.right = new TreeNode(18);
            int result= RangeSumBSTRecursive(root, L, R);
            Console.Write(result);
        }
        private static int RangeSumBSTRecursive(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root != null)
            {
                if (root.val >= L && root.val <= R)
                {
                    sum += root.val;
                }
                sum += (root.val >= L) ? RangeSumBSTRecursive(root.left, L, R) : 0;
                sum += (root.val <= R) ? RangeSumBSTRecursive(root.right, L, R) : 0;
            }
            return sum;
        }
    }
}
