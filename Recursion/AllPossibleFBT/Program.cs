using System;
using System.Collections.Generic;

namespace AllPossibleFBT
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = AllPossibleFBT(7);
            foreach (var item in t)
            {
                Print(item);
                Console.WriteLine();

            }
            Console.ReadKey();
        }

        private static void Print(TreeNode t)
        {
            if (t == null) { Console.Write("null"); return; }
            Print(t.left);
            Console.Write(t.val);
            Print(t.right);
        }

        private static IList<TreeNode> AllPossibleFBT(int N)
        {
            var res = new List<TreeNode>();
            if (N == 0) return null;
            if (N == 1)
            {
                var temp = new TreeNode(0);
                res.Add(temp);
                return res;
            }
            if (N % 2 == 0) return res;
            for (int i = 1; i < N; i += 2)
            {
                var left = AllPossibleFBT(i);
                var right = AllPossibleFBT(N - i - 1);
                foreach (var l in left)
                {
                    foreach (var r in right)
                    {
                        var root = new TreeNode(0);
                        root.left = l;
                        root.right = r;
                        res.Add(root);
                    }
                }
            }
            return res;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
