using System;
using System.Collections.Generic;

public class BSTIterator {
    public List<int> list=new List<int>();
    public int index=-1;

    public BSTIterator(TreeNode root) {
        Inorder(root);
    }
    
    public int Next() {
        return list[++index];
    }
    
    public bool HasNext() {
        return (index >= 0 && index < list.Count);        
    }

    public void Inorder(TreeNode root)
    {
        if(root ==  null) return;
        Inorder(root.left);
        list.Add(root.val);
        Inorder(root.right);
    }
}


/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */