using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Cousins_in_Binary_Tree
    {
        public static void Cousins_in_Binary_Tree_Main()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(4);
           // root.right.right = new TreeNode(5);
            Console.Write(IsCousins(root, 4,3));
        }

        private static bool IsCousins(TreeNode root, int x, int y)
        {
            if (root == null) return false;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            bool isXExist = false;
            bool isYExist = false;
            while (q.Count > 0)
            {
                int size = q.Count();
                isXExist = false;
                isYExist = false;
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = q.Dequeue();
                    
                    if (node != null)
                    {
                        if (node.val == x)
                        {
                            isXExist = true;
                        }
                        else if (node.val == y)
                        {
                            isYExist = true;
                        }

                        if (node.left != null && node.right != null)
                        {
                            if ((node.left.val == x && node.right.val == y) || (node.left.val == y && node.right.val == x))
                            {
                                return false;
                            }
                        }
                        if (node.left != null)
                        {
                            q.Enqueue(node.left);
                        }
                        if (node.right != null)
                        {
                            q.Enqueue(node.right);
                        }

                    }
                }
                if (isYExist && isXExist)
                {
                    return true;
                }
            }
            return false;
        }
        
    }

}
