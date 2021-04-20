using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class AverageofLevelsinBinaryTree
    {
        public static void AverageofLevelsinBinaryTree_Main()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.right = new TreeNode(5);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(2);
            root.right.left = new TreeNode(4);
            root.right.right = new TreeNode(6);
            var t = AverageOfLevels_Fun(root);
        }
        //[3,1,5,0,2,4,6]
        public static IList<double> AverageOfLevels_Fun(TreeNode root)
        {
            return AverageOfLevels_BFS(root);
        }

        private static IList<double> AverageOfLevels_BFS(TreeNode root)
        {
            List<double> list = new List<double>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            q.Enqueue(null);
            TreeNode data = null;
            double sum = 0;
            double count = 0;
            while (q.Count > 0)
            {
                data = q.Dequeue();
                if (data != null)
                {
                    count++;
                    sum += data.val;
                    if (data.left != null)
                    {
                        q.Enqueue(data.left);
                    }
                    if (data.right != null)
                    {
                        q.Enqueue(data.right);
                    }
                }
                else
                {
                    if (count > 0)
                    {
                        list.Add(sum / count);
                        sum = 0; count = 0;
                        q.Enqueue(null);
                    }
                }
            }
            return list;
        }
    }
}
