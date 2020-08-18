using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class N_ary_Tree_Postorder_Traversal
    {
        public static void N_ary_Tree_Postorder_TraversaMain()
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
            var result = N_ary_Tree_Postorder_TraversaRecursive(root);
            foreach (var item in result)
            {
                Console.Write(item + ",");
            }
        }
        private static IList<int> N_ary_Tree_Postorder_TraversaRecursive(MultiNode root)
        {
            IList<int> list1 = new List<int>();
            return N_ary_Tree_Postorder_TraversaRecursive1(root, list1);
        }
        private static IList<int> N_ary_Tree_Postorder_TraversaRecursive1(MultiNode root, IList<int> list1)
        {
            if (root != null)
            {
                if (root.children != null)
                {
                    foreach (var child in root.children)
                    {
                        N_ary_Tree_Postorder_TraversaRecursive1(child, list1);
                    }
                }
                list1.Add(root.val);
            }
            return list1;
        }
    }
}
