using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public static class FindtheMostCompetitiveSubsequence
    {

        public static int[] MostCompetitive(int[] nums, int k)
        {
            Stack<int> stack = new Stack<int>();
            int len = nums.Length;
            int count = 0;
            int countremaining = len - k;
            for (int i = 0; i < nums.Length; i++)
            {
                while (stack.Count > 0 && countremaining > 0 && stack.Peek() > nums[i])
                {
                    stack.Pop();
                    countremaining--;
                    count--;
                }
                if (count == k)
                {
                    countremaining--;
                    continue;
                }
                stack.Push(nums[i]);
                count++;
            }
            int[] result = new int[k];
            for (int j = 0; j < k; j++)
            {
                result[k - 1 - j] = stack.Pop();
            }
            return result;
        }        
    }
}
