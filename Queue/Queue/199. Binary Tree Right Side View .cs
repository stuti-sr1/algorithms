using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public static class BinaryTreeRightSideView
    {
        public static IList<int> RightSideView(TreeNode root)
        {
            IList<int> list = new List<int>();
            if (root == null) return list;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNode data = q.Dequeue();
                list.Add(data.val);
                if (data != null & data.right != null)
                {
                    q.Enqueue(data.right);
                }
            }
            return list;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
