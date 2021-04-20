using System;
using System.Collections.Generic;

namespace _1282._Group_the_People_Given_the_Group_Size_They_Belong_To
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] groupSizes = new int[] { 2, 1, 3, 3, 3, 2 };// { 3, 3, 3, 3, 3, 1, 3 };
            groupSizes = new int[] { 3, 3, 3, 3, 3, 1, 3 };
            //Console.WriteLine(GroupThePeople(groupSizes));
            Console.WriteLine(MinAddToMakeValid());
            Console.ReadKey();
        }

        public static IList<IList<int>> GroupThePeople1(int[] groupSizes)
        {
            IDictionary<int, IList<IList<int>>> map = new Dictionary<int, IList<IList<int>>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (map.ContainsKey(groupSizes[i]) && map[groupSizes[i]].Count < groupSizes[i])
                {
                    int l = map[groupSizes[i]].Count;
                    map[groupSizes[i]][0].Add(i);
                    //map[groupSizes[i]].Add(i);
                }
                else if (map.ContainsKey(groupSizes[i]) && map[groupSizes[i]].Count >= groupSizes[i])
                {
                    //map[groupSizes[i]].Add(i);
                }
                else
                {
                    int size = groupSizes[i];
                    List<int>[] outerlist = new List<int>[size];
                    List<int> innerlist = new List<int>();
                    innerlist.Add(i);
                    outerlist[0] = innerlist;
                    map[groupSizes[i]] = outerlist;
                }
            }
            return null;
        }
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            IDictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (!map.ContainsKey(groupSizes[i]))
                {
                    List<int> list = new List<int>();
                    list.Add(i);
                    map[groupSizes[i]] = list;
                }
                else
                {
                    map[groupSizes[i]].Add(i);
                }
            }
            IList<IList<int>> newList = new List<IList<int>>();
            foreach (var item in map)
            {
                IList<int> l1 = new List<int>();
                int i = 0;
                while (i <= item.Value.Count)
                {
                    if (i % item.Key == 0)
                    {
                        if (i > 0)
                        {
                            newList.Add(l1);
                        }
                        l1 = new List<int>();
                        //i = 0;
                    }
                    l1.Add(item.Value[i % item.Key]);
                    i++;
                }
            }
            return newList;
        }

        public static IList<int> PartitionLabels()
        {
            string s = "ababcbacadefegdehijhklij";
            var max = new int[26];
            var n = s.Length;
            for (int i = 0; i < n; i++)
                max[s[i] - 'a'] = i;

            var kpath = new List<int>();
            int start = 0;
            int end = 0;
            for (int i = 0; i < n; i++)
            {
                end = Math.Max(end, max[s[i] - 'a']);
                if (end == i)
                {
                    kpath.Add(end - start + 1);
                    start = i + 1;
                }
            }
            return kpath;
        }

        public static int MinAddToMakeValid()
        {
            string S = "()))((";
            int count = 0, bal = 0;
            for (int i = 0; i < S.Length; i++)
            {
                bal += S[i] == '(' ? 1 : -1;
                if (bal == -1)
                {
                    bal++;
                    count++;
                }
            }
            return count+bal;
        }
        public static int MinAddToMakeValid1()
        {
            string S = "()))((";
            int count = 0;
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    stack.Push(S[i]);
                }
                else if (S[i] == ')')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                    else count++;
                }
            }
            count += stack.Count;
            return Math.Abs(count);
        }
    }
}
