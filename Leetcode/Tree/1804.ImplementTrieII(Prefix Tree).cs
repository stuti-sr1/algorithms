using System;

public static class TrieSolutionII
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
                if(root.ContainsKey(c))
                {
                    root.count++;
                    //Console.WriteLine(c+"   "+root.count);
                }
                else root.Put(c,new TrieNode());
                root=root.Get(c);
            }
            root.isEndSet=true;
        }        
        public int CountWordsEqualTo(string word) {
            root=head;
            int wordCount=0;
            foreach (char c in word)
            {
                if(root.ContainsKey(c)){
                    root=root.Get(c);
                    Console.WriteLine(c+"   "+root.count);
                }
                //else return 0;
            }
            wordCount=root.count;
            return (root!=null && root.isEndSet)?wordCount:0;
        }        
        public int CountWordsStartingWith(string prefix) {
            root=head;
            int wordCount=0;
            foreach (char c in prefix)
            {
                if(root.ContainsKey(c)){
                    root=root.Get(c);
                }
                else return 0;
            }
            wordCount=root.count;
            return (root!=null)?wordCount:0;
        }        
        public void Erase(string word) {
            root=head;
            foreach (char c in word)
            {
                if(root.ContainsKey(c) )
                { 
                    if(root.count>=1)
                    {
                        root.count--;
                    }
                }
                root=root.Get(c);
            }
            if(root.count==0)
                root.isEndSet=false;
        }
    }

    public class TrieNode
    {
        public TrieNode[] children;
        public bool isEndSet;
        public int count;
        public int R=26;
        public TrieNode()
        {
            children=new TrieNode[R];
            isEndSet=false;
            count=1;
        }
        public bool ContainsKey(char c)
        {
            return children[c-'a']!=null;
        }
        public TrieNode Get(char c)
        {
            return children[c-'a'];
        }
        public void Put(char c,TrieNode node)
        {
            children[c-'a']=node;
        }
        public void Delete(char c,TrieNode node)
        {
            if(count>0)
            {
                children[c-'a']=null;
                count--;
            }
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