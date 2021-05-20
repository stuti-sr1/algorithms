using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumberofRecentCalls objNumberofRecentCalls = new NumberofRecentCalls();
            //int[] time = { 1, 100, 3001, 3002 };
            //var result = objNumberofRecentCalls.NumberofRecentCallsFun(time);

            //DesignCircularDeque objDesignCircularDeque = new DesignCircularDeque();
            //objDesignCircularDeque.DesignCircularDequeFun();

            //DesignCircularQueue objDesignCircularQueue = new DesignCircularQueue();
            //objDesignCircularQueue.DesignCircularQueueFun();

            ////int[] nums = { 3, 5, 2, 6 }; int k = 2;
            ////int[] nums = { 2, 4, 3, 3, 5, 4, 9, 6 }; int k = 4;
            //int[] nums = { 71, 18, 52, 29, 55, 73, 24, 42, 66, 8, 80, 2 };
            //int k = 3;
            //result = FindtheMostCompetitiveSubsequence.MostCompetitive(nums, k);

            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(5);
            root.right.right = new TreeNode(4);
            var result1 = BinaryTreeRightSideView.RightSideView(root);
            Console.ReadKey();
        }
    }
}
