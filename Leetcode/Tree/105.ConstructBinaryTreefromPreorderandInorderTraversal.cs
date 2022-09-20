using System;
using System.Collections.Generic;

public class BuildTreeSolution {
    public int preorderIndex=0;
    public Dictionary<int,int> map=new Dictionary<int,int>();

    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        for (int i = 0; i < inorder.Length; i++)
        {
            map.Add(inorder[i],i);
        }
        return RecursiveBuildTree(preorder,0,preorder.Length-1);        
    }

    public TreeNode RecursiveBuildTree(int[] preorder, int left,int right) {
        if(left > right) return null;
        int value=preorder[preorderIndex++];
        TreeNode root=new  TreeNode(value);
        root.left=RecursiveBuildTree(preorder,left,map[value]-1);
        root.right=RecursiveBuildTree(preorder,map[value]+1,right);
        return root;      
    }
}