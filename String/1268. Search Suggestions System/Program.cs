using System;
using System.Collections.Generic;

namespace _1268._Search_Suggestions_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = { "mobile", "mouse", "moneypot", "monitor", "mousepad" };
            string searchWord = "mouse";
            Console.WriteLine("Hello World!");
            var t = SuggestedProducts(products, searchWord);
            foreach (var items in t)
            {
                foreach (var item in items)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
        public static IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            Array.Sort(products);
            TrieNode root = new TrieNode();
            foreach (string product in products)
            {
                TrieNode curr = root;
                foreach (char c in product)
                {
                    if (curr.Children[c - 'a'] == null)
                    {
                        curr.Children[c - 'a'] = new TrieNode();
                    }
                    curr = curr.Children[c - 'a'];
                    if (curr.Suggestions.Count < 3)
                    {
                        curr.Suggestions.Add(product);
                    }
                }
            }
            IList<IList<string>> res = new List<IList<string>>();
            TrieNode curr2 = root;
            foreach (char c in searchWord)
            {
                if (curr2.Children[c - 'a'] != null)
                {
                    curr2 = curr2.Children[c - 'a'];
                    res.Add(curr2.Suggestions);
                }
                else res.Add(new List<string>());
            }
            return res;
        }
    }
    public class TrieNode
    {
        public TrieNode()
        {
            Suggestions = new List<string>();
            Children = new TrieNode[26];
        }
        public List<string> Suggestions { get; set; }
        public TrieNode[] Children { get; set; }
    }
}
