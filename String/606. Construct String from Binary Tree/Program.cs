using System;
using System.Text;

namespace _606._Construct_String_from_Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode t = new TreeNode(1);
            //t.left = new TreeNode(2);
            //t.left.left = new TreeNode(4);
            //t.right = new TreeNode(3);
            t.left = new TreeNode(2);
            t.left.right = new TreeNode(4);
            t.right = new TreeNode(3);
            Console.WriteLine(Tree2str(t));
            Console.ReadLine();
        }
        public static StringBuilder str = new StringBuilder();
        public static string Tree2str(TreeNode t)
        {
            return BuildString(t);
        }
        private static string BuildString(TreeNode t)
        {
            if (t==null)
            {
                return "";
            }
            if (t.left==null && t.right ==null)
            {
                return t.val+"";
            }
            if (t.right == null)
            {
                return t.val + "(" + BuildString(t.left) + ")";
            }
            return t.val + "(" + BuildString(t.left) + ")" + "(" + BuildString(t.right) + ")";
        }

        private static string BuildString1(TreeNode t)
        {
            str.Append(t.val);
            if (t.left != null)
            {
                str.Append("(");
                BuildString(t.left);
                str.Append(")");
            }
            if (t.right != null)
            {
                str.Append("(");
                BuildString(t.right);
                str.Append(")");
            }
            return str.ToString();
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
