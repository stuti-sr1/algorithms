using System;
using System.Collections.Generic;

public class BuildTreeSolutionI {
    public int postorderIndex;
    public Dictionary<int,int> map=new Dictionary<int,int>();
    
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        postorderIndex=postorder.Length-1;
        for (int i = 0; i < inorder.Length; i++)
        {
            map.Add(inorder[i],i);
        }
        return RecursiveBuildTree(postorder,0,postorder.Length-1);       
    }

    public TreeNode RecursiveBuildTree(int[] postorder,int start,int end) {
        if(start>end) return null;
        int value=postorder[postorderIndex--];
        TreeNode root=new TreeNode(value);
        root.right=RecursiveBuildTree(postorder,map[value]+1,end); 
        root.left=RecursiveBuildTree(postorder,start,map[value]-1); 
        return root;     
    }
    
}