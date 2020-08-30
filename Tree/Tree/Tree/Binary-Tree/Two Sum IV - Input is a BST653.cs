using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Two_Sum_IV_Input_is_a_BST
    {
        public static void Two_Sum_IV_Input_is_a_BST_Main()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(3);
            root.right = new TreeNode(6);
            root.left.left = new TreeNode(2);
            root.left.right = new TreeNode(4);
            root.right.right = new TreeNode(7);
            Console.Write(FindTarget(root, 9));
        }
        private static bool FindTarget(TreeNode root, int k)
        {
            HashSet<int> map = new HashSet<int>();
            return FindTarget_Recursion(root, k, map);
        }

        private static bool FindTarget_Recursion(TreeNode root, int k, HashSet<int> map)
        {
            if (root == null) return false;
            if (map.Contains(k - root.val)) return true;            
            map.Add(root.val);
            return FindTarget_Recursion(root.left, k, map) || FindTarget_Recursion(root.right, k, map);
        }
    }
}
