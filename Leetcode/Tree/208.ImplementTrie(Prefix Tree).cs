using System;

public static class TrieSolution
{
    public class Trie {
        TrieNode root;
        TrieNode head;
        public Trie() {
            root=new TrieNode();
            head=root;
        }    
        public void Insert(string word) {
            root=head;
            foreach (char c in word)
            {
                if(!root.ContainsKey(c))
                    root.Put(c,new TrieNode());     
                root=root.Get(c);               
            }
            root.SetEnd();
        }    
        public bool Search(string word) {
            root=head;
            foreach (char c in word)
            {
                if(!root.ContainsKey(c))
                    return false;     
                root=root.Get(c);               
            }
            return root!=null && root.IsEndSet();
        }    
        public bool StartsWith(string prefix) {
            root=head;
            foreach (char c in prefix)
            {
                if(!root.ContainsKey(c))
                    return false;
                root=root.Get(c);   
            }
            return root!=null;
        }
    }
    public class TrieNode{
        int R=26;
        TrieNode[] children;
        bool isEndSet;
        public TrieNode()
        {
            children = new TrieNode[R];
            isEndSet=false;
        }
        public TrieNode Get(char c)
        {
            return children[c-'a'];
        }
        public bool ContainsKey(char c)
        {
            return children[c-'a'] != null;
        }
        public void Put(char c, TrieNode node)
        {
            children[c-'a'] = node;
        }
        public void SetEnd()
        {
            isEndSet=true;
        }
        public bool IsEndSet()
        {
            return isEndSet;
        }
    }
}