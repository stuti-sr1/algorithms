using System;
using System.Collections.Generic;

public class LRUCache {

    public int capacity;
    public Dictionary<int,LinkedListNode<Cache>> map;
    public LinkedList<Cache> list;

    public LRUCache(int capacity) {
        this.capacity=capacity;
        map=new Dictionary<int, LinkedListNode<Cache>>();
        list=new LinkedList<Cache>();       
    }    

    public int Get(int key) {

        if(map.ContainsKey(key))
        {
            var newCache=map[key];
            list.Remove(newCache.Value);
            list.AddFirst(newCache);
            return newCache.Value.val;
        }
        else return -1;
    }  

    public void Put(int key, int value) {
        if(map.ContainsKey(key))
        {
            map[key].Value.val=value;
            var newCache = map[key];
            list.Remove(newCache.Value);
            list.AddFirst(newCache);
        }   
        else
        {
            Cache newCache=new Cache(key,value);
            map.Add(key, new LinkedListNode<Cache>(newCache));            
            list.AddFirst(newCache);
            if(list.Count > capacity )
            {
                LinkedListNode<Cache> lastCache = list.Last;
                map.Remove(lastCache.Value.key);
                list.Remove(lastCache);
            }
        }  
        return;  
    }
}
public class Cache{
    public int key { get; set; }
    public int val { get; set; }
    public Cache(int key,int val)
    {
        this.key=key;
        this.val=val;        
    }    
}
