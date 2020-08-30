using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class BT_Level_Order_Traversal
    {
        public static void BT_Level_Order_Traversal_Main()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            IList<IList<int>> t = LevelOrderBottom(null);
        }
        public static IList<IList<int>> LevelOrderBottom(TreeNode root)
        {
            IList<int> newList = new List<int>();
            IList<IList<int>> list = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    TreeNode newnode = queue.Dequeue();
                    if (newnode != null)
                    {
                        newList.Add(newnode.val);
                        if (newnode.left != null)
                        {
                            queue.Enqueue(newnode.left);
                        }
                        if (newnode.right != null)
                        {
                            queue.Enqueue(newnode.right);
                        }
                    }
                }
                if (newList.Count > 0)
                {
                    list.Add(newList);
                }
                newList = new List<int>();
            }
            return list.Reverse().ToList();
        }

        public static IList<IList<int>> LevelOrderBottom1(TreeNode root)
        {
            IList<int> newList = new List<int>();
            IList<IList<int>> list = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);
            while (queue.Count > 0)
            {
                TreeNode newNode = queue.Dequeue();
                if (newNode != null)
                {
                    newList.Add(newNode.val);
                    if (newNode.left != null)
                    {
                        queue.Enqueue(newNode.left);
                    }
                    if (newNode.right != null)
                    {
                        queue.Enqueue(newNode.right);
                    }
                }
                else
                {
                    list.Add(newList);
                    newList = new List<int>();
                    if (queue.Count > 0)
                    {
                        queue.Enqueue(null);
                    }
                }
            }
            return list.Reverse().ToList();
        }
    }
}
