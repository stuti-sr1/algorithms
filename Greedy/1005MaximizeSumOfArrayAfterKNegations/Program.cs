using System;
using System.Linq;

namespace _1005MaximizeSumOfArrayAfterKNegations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 4, 2, 3 }; int k = 1;
            A = new int[] { 2, -3, -1, 5, -4 }; k = 2;
            //A = new int[] { 3, -1, 0, 2 };  k = 3;
            Console.WriteLine(LargestSumAfterKNegations1(A, k));
            Console.ReadKey();
        }
        static Heap heap;
        private static int LargestSumAfterKNegations1(int[] A, int k)
        {
            heap = new Heap(A.Length);
            for (int i = 0; i < A.Length; i++)
            {
                Insert(A[i]);
            }
            while (k > 0)
            {
                k--;
                int value = GetMin();
                DeleteMin();
                Insert(-value);
            }
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sum += GetMin();
                DeleteMin();
            }
            return sum;
        }
        private static void Insert(int value)
        {
            if (heap == null) return;
            if (heap.count == heap.capacity) return;
            int i = heap.count;
            heap.count += 1;
            heap.array[i] = value;
            int parent = (i - 1) / 2;
            while (heap.array[i] < heap.array[parent])
            {
                int temp = heap.array[parent];
                heap.array[parent] = heap.array[i];
                heap.array[i] = temp;
                i = parent;
                parent = (i - 1) / 2;
            }
        }
        private static int GetMin()
        {
            if (heap == null)
            {
                return int.MaxValue;
            }
            return heap.array[0];
        }

        private static int DeleteMin()
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
            int min;
            if (left != int.MaxValue && heap.array[left] < heap.array[i]) min = left;
            else min = i;
            if (right != int.MaxValue && heap.array[right] < heap.array[min]) min = right;
            if (min != i)
            {
                int temp = heap.array[min];
                heap.array[min] = heap.array[i];
                heap.array[i] = temp;
                PercolateDown(heap, min);
            }
        }

        private static int RightChild(int parent)
        {
            int v = parent * 2 + 2;
            if (heap.count >= v)
            {
                return v;
            }
            return int.MaxValue;
        }

        private static int LeftChild(int parent)
        {
            int v = parent * 2 + 1;
            if (heap.count >= v)
            {
                return v;
            }
            return int.MaxValue;
        }

        public static int LargestSumAfterKNegations(int[] A, int K)
        {
            Array.Sort(A);
            var negCount = A.Where(x => x < 0).Count();
            int len = K > negCount ? negCount : K;
            for (int i = 0; i < len; i++)
            {
                A[i] = -A[i];
                K--;
            }
            Array.Sort(A);
            while (K > 0)
            {
                A[0] = -A[0];
                K--;
            }
            return A.Sum(x => x);
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
