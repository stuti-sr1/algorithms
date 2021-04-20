using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] deck = { 17, 13, 11, 2, 3, 5, 7 };
            var u = deckRevealedIncreasing(deck);
            int[] flowerbed = { 1, 0, 0, 0, 1 };
            Console.WriteLine(CanPlaceFlowers(flowerbed, 2));
            int[] nums1 = { -1, -1, -1, 0, 1, 1 };
            int t1 = PivotIndex(nums1);
            int[] nums = { 9, 6, 4, 2, 3, 5, 8, 0, 1 };
            int y = MissingNumber(nums);
            int t = FindShortestSubArray();
            //int[] A = { 100 };
            //Console.WriteLine(TwoSumLessThanK(A, 200));
            int[] A = { 4, 3, 2, 7, 8, 2, 3, 1 };
            Console.WriteLine(FindDisappearedNumbers(A));
            Console.ReadKey();
        }
        public static int[] deckRevealedIncreasing(int[] deck)
        {
            int n = deck.Length;
            Array.Sort(deck);
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < n; i++) q.Enqueue(i);
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[q.Dequeue()] = deck[i];
                q.Enqueue(q.Dequeue());
            }
            return res;
        }
        public static bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            for (int k = 1; k < flowerbed.Length - 1; k++)
            {
                if (flowerbed[k] == 0 && flowerbed[k - 1] == 1)
                {
                    if (flowerbed[k + 1] == 0)
                    {
                        flowerbed[k + 1] = 1;
                        count++;
                    }
                    else return false;
                }
                else if (flowerbed[k] == 1 && flowerbed[k - 1] == 0)
                {
                    if (flowerbed[k + 1] == 1)
                    {
                    }
                    else return false;
                }
                if (count >= n)
                {
                    return true;
                }
            }
            return count >= n;
        }
        public static int MissingNumber(int[] nums)
        {
            int missing = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(missing);
                Console.Write(i);
                Console.Write(nums[i]);
                missing ^= i ^ nums[i];
                Console.WriteLine(missing);
            }
            return missing;
        }
        public static int FindShortestSubArray()
        {
            int[] num = { 2, 1, 1, 2, 1, 3, 3, 3, 1, 3, 1, 3, 2 };
            Dictionary<int, Num> map = new Dictionary<int, Num>();
            int maxFreq = 0;
            int maxLen = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (!map.ContainsKey(num[i]))
                {
                    map[num[i]] = new Num(i, i, 1);
                }
                else
                {
                    map[num[i]].end = i;
                    map[num[i]].freq++;
                }
                if (maxFreq < map[num[i]].freq)
                {
                    maxFreq = map[num[i]].freq;
                    maxLen = map[num[i]].end - map[num[i]].start;
                }
                else if (maxFreq == map[num[i]].freq)
                {
                    int c = map[num[i]].end - map[num[i]].start;
                    maxLen = maxLen < c ? maxLen : c;
                }
            }
            Console.Write(maxLen + 1);
            return maxLen;
        }
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            int temp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 != nums[i])
                {
                    while (i + 1 != nums[i])
                    {

                        temp = nums[i];
                        if (nums[i] == nums[temp - 1]) break;
                        nums[i] = nums[temp - 1];
                        nums[temp - 1] = temp;
                    }
                }
            }
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + 1 != nums[i])
                    list.Add(i + 1);
            }
            return list;
        }
        public static int TwoSumLessThanK(int[] A, int K)
        {
            Array.Sort(A);
            int i = 0;
            int j = A.Length - 1;
            if (j == 0)
                return A[j];
            int sum = 0;
            int max = -1;
            while (i < j)
            {
                sum = A[i] + A[j];
                if (sum == K)
                    return sum;
                else if (sum > K)
                {
                    j--;
                }
                else
                {
                    i++;
                }
                if (sum > max && sum <= K)
                {
                    max = sum;
                }
            }
            return max;
        }
        public static int PivotIndex(int[] nums)
        {
            if (nums.Length < 3) return -1;
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                sum2 += nums[i];
            }
            for (int i = 1; i < nums.Length - 1; i++)
            {
                sum1 += nums[i - 1];
                sum2 -= nums[i];
                if (sum1 == sum2)
                {
                    return i;
                }
            }
            return -1;
        }
    }
    public class Num
    {
        public Num(int start, int end, int freq)
        {
            this.start = start;
            this.end = end;
            this.freq = freq;
        }
        public int start;
        public int end;
        public int freq;
    }
}

