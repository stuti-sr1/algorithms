using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Maximum_Depth_of_N_ary_Tree
    {
        public static void Maximum_Depth_of_N_ary_TreeMain()
        {
            //Input: root = [1, null, 3, 2, 4, null, 5, 6]
            IList<MultiNode> list = new List<MultiNode>();
            list.Add(new MultiNode(3));
            list.Add(new MultiNode(2));
            list.Add(new MultiNode(4));
            MultiNode root = new MultiNode(1, list);
            list = new List<MultiNode>();
            list.Add(new MultiNode(5));
            list.Add(new MultiNode(6));
            root.children[0].children = list;
            int result = Maximum_Depth_of_N_ary_TreeRecursive(root);
            Console.Write(result);
        }

        private static int Maximum_Depth_of_N_ary_TreeRecursive(MultiNode root)
        {
            if (root == null) return 0;
            List<int> ht = new List<int>();
            foreach (var child in root.children)
            {
                ht.Add(Maximum_Depth_of_N_ary_TreeRecursive(child));
            }
            return ht.Count > 0 ? ht.Max() + 1 : 1;
        }
    }
}
