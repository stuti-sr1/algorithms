using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class SumofRootToLeafBinaryNumbers
    {
        public static void SumofRootToLeafBinaryNumbers_Main()
        {
            TreeNode root = new TreeNode(1);
            //root.left = new TreeNode(0);
            root.right = new TreeNode(0);
            //root.left.left = new TreeNode(0);
            //root.left.right = new TreeNode(1);
            //root.right.left = new TreeNode(0);
            //root.right.right = new TreeNode(1);
            SumofRootToLeafBinaryNumbers_Fun(root);
        }
        private static void SumofRootToLeafBinaryNumbers_Fun(TreeNode root)
        {
            List<int> path = new List<int>();
            int res = SumofRootToLeafBinaryNumbers_Recursion(root, 0);
            Console.WriteLine(res);
        }
        private static int SumofRootToLeafBinaryNumbers_Recursion(TreeNode root, int val)
        {
            if (root == null) return 0;
            val = 2 * val + root.val;
            return root.left == root.right ? val : SumofRootToLeafBinaryNumbers_Recursion(root.left, val) + SumofRootToLeafBinaryNumbers_Recursion(root.right, val);
        }

    }
}
