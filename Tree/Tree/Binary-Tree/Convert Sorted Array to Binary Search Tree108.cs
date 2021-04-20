using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    public class Convert_Sorted_Array_to_Binary_Search_Tree
    {
        public static void Convert_Sorted_Array_to_Binary_Search_Tree_Main()
        {
            int[] nums = { -10, -3, 0, 5, 9 };
            TreeNode tree = SortedArrayToBST(nums);
            Console.ReadKey();
        }
        //TreeNode res;
        private static TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST_Recursion(nums, 0, nums.Length - 1);
        }

        private static TreeNode SortedArrayToBST_Recursion(int[] nums, int start, int end)
        {
            if (start > end)
                return null;
            int mid = (end + start) / 2;
            TreeNode root = new TreeNode(nums[mid]);
            root.left = SortedArrayToBST_Recursion(nums, start, mid - 1);
            root.right = SortedArrayToBST_Recursion(nums, mid + 1, end);
            return root;

        }
    }
}
