using System;

namespace _455AssignCookies
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] g = new int[] { 1, 2, 3 };
            //int[] s = new int[] { 1, 1 };
            //int[] g = new int[] { 1, 2 };
            //int[] s = new int[] { 1, 2, 3 };
            int[] g = new int[] { 10, 9, 8, 7 };
            int[] s = new int[] { 5, 6, 7, 8 };
            Console.WriteLine(FindContentChildren1(g, s));
            Console.ReadKey();
        }

        private static int FindContentChildren1(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int g_len = g.Length;
            int s_len = s.Length;
            int i = 0, j = 0, count = 0;
            while (i < g_len && j < s_len)
            {
                if (g[i] <= s[j])
                {
                    i++; j++; count++;
                }
                else j++;
            }
            return count;
        }



        static Heap heap_G;
        static Heap heap_S;
        public static int FindContentChildren(int[] g, int[] s)
        {
            heap_G = new Heap(g.Length);
            heap_S = new Heap(s.Length);
            for (int i = 0; i < g.Length; i++)
            {
                Insert(g[i], heap_G);
            }
            for (int i = 0; i < s.Length; i++)
            {
                Insert(s[i], heap_S);
            }
            int len = g.Length < s.Length ? g.Length : s.Length;
            int sum = 0;
            while (heap_S.count > 0 && heap_G.count > 0)
            {
                int s_Min = GetMin(heap_S);
                int g_Min = GetMin(heap_G);
                if (g_Min <= s_Min)
                {
                    DeleteMin(heap_S);
                    DeleteMin(heap_G);
                    sum++;
                }
                else
                {
                    DeleteMin(heap_S);
                }
            }
            return sum;
        }

        private static void Insert(int value, Heap heap)
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
        private static int GetMin(Heap heap)
        {
            if (heap == null)
            {
                return int.MaxValue;
            }
            return heap.array[0];
        }

        private static int DeleteMin(Heap heap)
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
            int left = LeftChild(i, heap);
            int right = RightChild(i, heap);
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

        private static int RightChild(int parent, Heap heap)
        {
            int v = parent * 2 + 2;
            if (heap.count >= v)
            {
                return v;
            }
            return int.MaxValue;
        }

        private static int LeftChild(int parent, Heap heap)
        {
            int v = parent * 2 + 1;
            if (heap.count >= v)
            {
                return v;
            }
            return int.MaxValue;
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
