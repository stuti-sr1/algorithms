using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionEasy
{
    public static class sum_of_nodes_L_R
    {
        public static int RangeSumBST(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root != null)
            {
                if (root.val >= L && root.val <= R)
                {
                    sum += root.val;
                }
                sum += (root.val > L) ? RangeSumBST(root.left, L, R) : 0;
                sum += (root.val < R) ? RangeSumBST(root.right, L, R) : 0;
            }
            return sum;
        }
        public static int RangeSumBST1(TreeNode root, int L, int R)
        {
            int sum = 0;
            if (root != null)
            {
                if (root.val >= L && root.val <= R)
                {
                    sum += root.val;
                }
                return RangeSumBST(root.left, L, R) + RangeSumBST(root.right, L, R) + sum;
            }
            return sum;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
