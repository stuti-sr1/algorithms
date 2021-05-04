using System;

namespace RecursionEasy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Tribonacci.TribonacciFun(25));


            TreeNode root = new TreeNode(10);
            root.left = new TreeNode(5);
            root.left.left = new TreeNode(3);
            root.left.right = new TreeNode(7);
            root.right = new TreeNode(15);
            root.right.right = new TreeNode(18);
            Console.WriteLine(sum_of_nodes_L_R.RangeSumBST(root, 7, 15));


            Console.ReadKey();
        }
    }
}
