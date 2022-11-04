using System;
using System.Linq.Expressions;
using System.Collections.Generic;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode l1=new ListNode(9);
            l1.next=new ListNode(9);
            l1.next.next=new ListNode(9);
            l1.next.next.next=new ListNode(9);
            l1.next.next.next.next=new ListNode(9);
            l1.next.next.next.next.next=new ListNode(9);
            l1.next.next.next.next.next.next=new ListNode(9);

            ListNode l2=new ListNode(9);
            l2.next=new ListNode(9);
            l2.next.next=new ListNode(9);
            l2.next.next.next=new ListNode(9);

            //ListNode t= AddTwoNumbersFun.AddTwoNumbers(l1,l2);
            
            //PrintLinkedListInReverseSolution.PrintLinkedListInReverse(l1);
            int[] nums1={2,1,4,5,7};
            int[] nums2={3,2,4,8,6};
            //MinProductSumSolution.MinProductSum(nums1,nums2);

           //Console.WriteLine(ZigzagConversionSolution.Convert("ABCDEFGHIJKLMNOP",4));
            // [1,2,3,4,5,null,6,7,null,null,null,null,8]
           TreeNode root=new TreeNode(1);
           root.left=new TreeNode(2);
           root.right=new TreeNode(3);
           root.left.left=new TreeNode(4);
           root.left.right=new TreeNode(5);
           root.left.left.left=new TreeNode(7);
           root.right.right=new TreeNode(6);
           //root.right.right.right=new TreeNode(8);
           //Console.WriteLine(Codec.serialize(root));
           //Console.WriteLine(LevelOrderSolution.LevelOrder(root));

        //    root=new TreeNode(1);
        //    root.left=new TreeNode(2);
        //    root.right=new TreeNode(3);
// [-10,9,20,null,null,15,7]
           root=new TreeNode(-1);
           root.left=new TreeNode(2);
        //    root.right=new TreeNode(20);
        //    root.right.right=new TreeNode(7);
        //    root.right.left=new TreeNode(15);

           //Console.WriteLine(MaxPathSumSolution.MaxPathSum(root));
           //Console.WriteLine(DeepestLeavesSumSolution.DeepestLeavesSum(root)); 

            int[] plants = {2,2,3,3};
            //int capacity = 5;
            //Console.WriteLine(WateringPlantsSolution.WateringPlants(plants,capacity));

           root=new TreeNode(1);
           root.left=new TreeNode(2);
           root.right=new TreeNode(3);
           root.left.left=new TreeNode(4);
           root.left.right=new TreeNode(5);
           IList<IList<int>>  test= FindLeavesofBinaryTreeSolution.FindLeaves(root);
            int[] nums= new int[]{1,2,3};
            PermutationsSolution.Permute(nums);
            nums=new int[]{1,1,2};
            PermutationsIISolution.PermuteUnique(nums);

            //CombineSolution.Combine(4,2);
            
            LetterCombinationsSolution.LetterCombinations("");

            char[][] board = new char[9][];
            board[0]=new char[]{'5','3','.','.','7','.','.','.','.'};
            board[1]=new char[]{'6','.','.','1','9','5','.','.','.'};
            board[2]=new char[]{'.','9','8','.','.','.','.','6','.'};
            board[3]=new char[]{'8','.','.','.','6','.','.','.','3'};
            board[4]=new char[]{'4','.','.','8','.','3','.','.','1'};
            board[5]=new char[]{'7','.','.','.','2','.','.','.','6'};
            board[6]=new char[]{'.','6','.','.','.','.','2','8','.'};
            board[7]=new char[]{'.','.','.','4','1','9','.','.','5'};
            board[8]=new char[]{'.','.','.','.','8','.','.','7','9'};

            //SolveSudokuSolution.SolveSudoku(board);

            nums = new int[]{1,2,3};
            //SubsetsSolution.Subsets(nums);
            //GenerateParenthesisSolution.GenerateParenthesis(2);
            //Console.WriteLine(ClimbStairsSolution.ClimbStairs(3));

            int[] cost =new int[]{10,15,20};
           // Console.WriteLine(MinCostClimbingStairsSolution.MinCostClimbingStairs(cost));

            nums = new int[] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};
            //{1,2,3,1};
           // Console.WriteLine(RobSolution.Rob(nums));

            // nums = new int[] {200,3,140,20,10};
            // Console.WriteLine(RobIISolution.Rob(nums));

            int[]  coins = {1,2,5};
            int amount = 11;
           // Console.WriteLine(CoinChangeSolution.CoinChange(coins,amount));

            //text1 = "abcde", text2 = "ace"
            //Console.WriteLine(LCSSolution.LongestCommonSubsequence("ezupkr","ubmrapg"));
            //Console.WriteLine(LCSSolution.LongestCommonSubsequence("bsbininm","jmjkbkjkv"));
            //Console.WriteLine(UniquePathsSolution.UniquePaths(23,12));
            nums = new int[] {2,0};// {3,2,1,0,4};
            //Console.WriteLine(CanJumpSolution.CanJump(nums));
            //Console.WriteLine(NumDecodingsSolution.NumDecodings("226"));

// ["LRUCache", "put", "put", "get", "put", "get", "put", "get", "get", "get"]
// [[2], [1, 1], [2, 2], [1], [3, 3], [2], [4, 4], [1], [3], [4]]
// Output
// [null, null, null, 1, null, -1, null, -1, 3, 4]

            // LRUCache obj = new LRUCache(2);
            // obj.Put(1,1);
            // obj.Put(2,2);
            // Console.WriteLine(obj.Get(1));            
            // obj.Put(3,3);
            // Console.WriteLine(obj.Get(2));
            // obj.Put(4,4);
            // Console.WriteLine(obj.Get(1));
            // Console.WriteLine(obj.Get(3));
            // Console.WriteLine(obj.Get(4));

            int[] arr={2,3,1,1,4};
            //SolutionJumpII.Jump(arr);

            // TrieSolution.Trie obj=new TrieSolution.Trie();
            // obj.Insert("apple");
            // bool param_2 = obj.Search("apple");
            // bool param_3 = obj.Search("app");
            // bool param_4 = obj.StartsWith("app");
            // obj.Insert("app");
            // bool param_5 = obj.Search("app");
            // Console.WriteLine(param_2);
            // Console.WriteLine(param_3);
            // Console.WriteLine(param_4);
            // Console.WriteLine(param_5);


            TrieSolutionII.Trie obj=new TrieSolutionII.Trie();
            obj.Insert("apple");
            obj.Insert("apple");
            int par_2 = obj.CountWordsEqualTo("apple");
            // int par_3 = obj.CountWordsStartingWith("app");
            // obj.Erase("apple");
            // int par_4 = obj.CountWordsEqualTo("apple");
            // int par_5 = obj.CountWordsStartingWith("app");
            // obj.Erase("apple");
            // int par_6= obj.CountWordsStartingWith("app");
            Console.WriteLine(par_2);
            // Console.WriteLine(par_3);
            // Console.WriteLine(par_4);
            // Console.WriteLine(par_5);
            // Console.WriteLine(par_6);
// ["Trie", "insert", "insert", "countWordsEqualTo", "countWordsStartingWith", "erase", "countWordsEqualTo", "countWordsStartingWith", "erase", "countWordsStartingWith"]
// [[], ["apple"], ["apple"], ["apple"], ["app"], ["apple"], ["apple"], ["app"], ["apple"], ["app"]]
// Output
// [null, null, null, 2, 2, null, 1, 1, null, 0]
            Console.WriteLine("Hello stuti!");
        }
    }
}

// ["LRUCache","put","put","get","put","get","put","get","get","get"]
// [[2],[1,1],[2,2],[1],[3,3],[2],[4,4],[1],[3],[4]]
// ["LRUCache","put","get"]
// [[1],[2,1],[2]]
// ["LRUCache","put","put","put","put","get","get"]
// [[2],[2,1],[1,1],[2,3],[4,1],[1],[2]]
