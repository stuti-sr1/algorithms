using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class RootToLeaveBinarySum
    {
        public static void RootToLeaveBinarySum_Main()
        {
            //Input: root = [3,9,20,null,null,15,7]
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(6);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(7);
            RootToLeaveBinarySum_Fun(root);
        }

        private static void RootToLeaveBinarySum_Fun(TreeNode root)
        {
            List<int> path = new List<int>();
            RootToLeaveBinarySum_Recursion(root, path);
        }

        private static void RootToLeaveBinarySum_Recursion(TreeNode root, List<int> path)
        {
            if (root == null) return;
            if (root.left == null && root.right == null)
            {
                path.Add(root.val);
                string sum = string.Empty;
                foreach (var value in path)
                {
                    sum += value;
                }
                Console.WriteLine(sum);
                return;
            };
            path.Add(root.val);
            if (root.left != null)
            {
                RootToLeaveBinarySum_Recursion(root.left, path);
            }
            path.RemoveAt(path.Count - 1);
            if (root.right != null)
            {
                RootToLeaveBinarySum_Recursion(root.right, path);
            }
            path.RemoveAt(path.Count - 1);
            return;
        }
    }
}
