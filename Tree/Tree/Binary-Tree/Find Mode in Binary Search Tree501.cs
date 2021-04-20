using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Find_Mode_in_Binary_Search_Tree
    {
        public static void Find_Mode_in_Binary_Search_Tree_Main()
        {
            TreeNode root = new TreeNode(1);
            root.right = new TreeNode(2);
            root.right.left = new TreeNode(2);
            var t = FindMode(root);
            Console.ReadKey();
        }
        public static int[] FindMode(TreeNode root)
        {
            IDictionary<int, int> map = new Dictionary<int, int>();
            FindMode_Recursion(root, map);
            map = map.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            List<int> res = new List<int>();
            int i = 0;
            int val = -1;
            foreach (var item in map)
            {
                if (i == 0)
                {
                    res.Add(item.Key);
                    val = item.Value;
                }
                else if (val == item.Value)
                {
                    res.Add(item.Key);
                }
                else break;
                i++;
            }
            return res.ToArray();
        }

        private static void FindMode_Recursion(TreeNode root, IDictionary<int, int> map)
        {
            if (root == null) return;
            FindMode_Recursion(root.left, map);
            if (map.ContainsKey(root.val))
            {
                int val = map[root.val];
                map[root.val] = val + 1;
            }
            else
            {
                map[root.val] = 1;
            }
            FindMode_Recursion(root.right, map);
        }
    }
}
