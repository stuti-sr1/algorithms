using System;

namespace KthLargestElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 2, 1, 5, 6, 4 };
            int k = 2;
            Console.WriteLine(FindKthLargest(a, k));
            Console.ReadKey();
        }
        static Heap heap;
        public static int FindKthLargest(int[] nums, int k)
        {
            heap = new Heap(nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                Insert(nums[i]);
            }
            int data=int.MinValue;
            for (int i = 0; i < k; i++)
            {
                data = GetMax();
                DeleteMax();
            }
            return data;
        }

        public static void DeleteMax()
        {
            if (heap.count == 0) return;
            int data = heap.array[0];
            heap.array[0] = heap.array[heap.count - 1];
            heap.count--;
            PercolateDown(0);
        }

        private static void PercolateDown(int i)
        {
            if (heap == null || heap.count == 0) return;
            int l = LeftChild(i);
            int r = RightChild(i);
            int max;
            if (l != int.MinValue && heap.array[i] < heap.array[l])
            {
                max = l;
            }
            else
            {
                max = i;
            }
            if (r != int.MinValue && heap.array[max] < heap.array[r])
            {
                max = r;
            }
            if (max != i)
            {
                int temp = heap.array[max];
                heap.array[max] = heap.array[i];
                heap.array[i] = temp;
                PercolateDown(max);
            }
        }

        public static int LeftChild(int i)
        {
            int v = i * 2 + 1;
            if (heap.count < v) return int.MinValue;
            return v;
        }
        public static int RightChild(int i)
        {
            int v = i * 2 + 2;
            if (heap.count < v) return int.MinValue;
            return v;
        }
        public static int GetMax()
        {
            if (heap.count == 0) return int.MinValue;
            return heap.array[0];
        }
        public static void Insert(int v)
        {
            if (heap.capacity <= heap.count)
            {
                return;
            }
            int i = heap.count;
            heap.array[i] = v;
            heap.count++;
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
    }
    public class Heap
    {
        public Heap(int capacity)
        {
            this.capacity = capacity;
            this.count = 0;
            this.array = new int[capacity];
        }
        public int capacity { get; set; }
        public int count { get; set; }
        public int[] array { get; set; }
    }
}
