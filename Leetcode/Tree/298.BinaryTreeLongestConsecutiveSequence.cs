using System;
using System.Collections.Generic;


public class LongestConsecutiveSolution {
    
    public int maxCount=0;
    public int LongestConsecutive(TreeNode root) {
        DFS(root);
        return maxCount;
    }
    public int DFS(TreeNode root)
    {
        if(root == null) return 0;
        int left = DFS(root.left)+1;
        int right= DFS(root.right)+1;
        if(root.left != null && root.val+1 != root.left.val) left=1;
        if(root.right != null && root.val+1 != root.right.val) right=1;
        int len=Math.Max(left,right);
        maxCount=Math.Max(len,maxCount);
        return len;
    }
    // public void DFS(TreeNode root)
    // {        
    //     if(root!=null)
    //     {
    //         Console.WriteLine(root.val);
    //         if(root.left !=null )
    //         {
    //             if(root.val+1 == root.left.val) 
    //             {
    //                 leftCount++; 
    //                 maxCount=Math.Max(maxCount,leftCount);
    //             }
    //             else leftCount=0;                
    //             DFS(root.left);                
    //         }
    //         if(root.right !=null )
    //         {
    //             if(root.val+1 == root.right.val) 
    //             {
    //                 rightCount++;  
    //                 maxCount=Math.Max(maxCount,rightCount);
    //             }
    //             else rightCount=0;
    //             DFS(root.right);                
    //         }
    //     }
    // }
}