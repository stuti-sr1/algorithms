using System;
using System.Collections.Generic;
using System.Linq;

namespace _1046.LastStoneWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stones = new int[] { 2, 7, 4, 1, 8, 1 };
            stones = new int[] { 7, 5, 6, 9, 10, 5 };
            int ans = LastStoneWeight1(stones);
            Console.WriteLine(ans);
            Console.ReadKey();
        }

        static Heap heap;
        public static int LastStoneWeight1(int[] stones)
        {
            heap = new Heap(stones.Length);
            for (int i = 0; i < stones.Length; i++)
            {
                Insert(stones[i]);
            }
            while (heap.count > 1)
            {
                int a = GetMax();
                DeleteMax();
                int b = GetMax();
                DeleteMax();
                int diffWt = Math.Abs(a - b);
                if (diffWt > 0)
                {
                    Insert(diffWt);
                }
            }
            if (heap.count > 0)
            {
                return GetMax();
            }
            return 0;
        }

        public static int LastStoneWeight(int[] stones)
        {
            List<int> list = new List<int>(stones);
            while (list.Count > 1)
            {
                list = list.OrderByDescending(x => x).ToList();
                int a = list[0];
                int b = list[1];
                list.RemoveAt(1);
                list.RemoveAt(0);
                int diffWt = Math.Abs(a - b);
                if (diffWt > 0)
                {
                    list.Add(diffWt);
                }
            }
            if (list.Count > 0)
            {
                return list[0];
            }
            return 0;
        }

        private static void Insert(int value)
        {
            if (heap == null) return;
            if (heap.count == heap.capacity) return;
            int i = heap.count;
            heap.count += 1;
            heap.array[i] = value;
            int parent = (i - 1) / 2;
            while (heap.array[i] > heap.array[parent])
            {
                int temp = heap.array[parent];
                heap.array[parent] = heap.array[i];
                heap.array[i] = temp;
                i = parent;
                parent = (i - 1) / 2;
            }


        }
        private static int GetMax()
        {
            if (heap == null)
            {
                return int.MinValue;
            }
            return heap.array[0];
        }

        private static int DeleteMax()
        {
            if (heap == null || heap.count == 0) return int.MinValue;
            int data = heap.array[0];
            heap.array[0] = heap.array[heap.count - 1];
            heap.count--;
            PercolateDown(heap, 0);
            return data;
        }

        private static void PercolateDown(Heap heap, int i)
        {
            if (heap == null || heap.count == 0) return;
            int left = LeftChild(i);
            int right = RightChild(i);
            int max;
            if (left != int.MinValue && heap.array[left] > heap.array[i])
            {
                max = left;
            }
            else
            {
                max = i;
            }
            if (right != int.MinValue && heap.array[right] > heap.array[max])
            {
                max = right;
            }
            if (max != i)
            {
                int temp = heap.array[max];
                heap.array[max] = heap.array[i];
                heap.array[i] = temp;
                PercolateDown(heap, max);

            }
        }

        private static int RightChild(int parent)
        {
            int v = parent * 2 + 2;
            if (heap.count >= v)
            {
                return v;
            }
            return int.MinValue;
        }

        private static int LeftChild(int parent)
        {
            int v = parent * 2 + 1;
            if (heap.count >= v)
            {
                return v;
            }
            return int.MinValue;
        }
    }

    class Heap
    {
        public int[] array { get; set; }
        public int capacity { get; set; }
        public int count { get; set; }
        public Heap(int capacity)
        {
            array = new int[capacity];
            count = 0;
            this.capacity = capacity;
        }
    }
}
