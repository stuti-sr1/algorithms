using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.right = new TreeNode(15);
            root.right.right = new TreeNode(18);
            Console.WriteLine(RangeSumBST(root, 7, 15));
            Console.ReadKey();
        }
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
