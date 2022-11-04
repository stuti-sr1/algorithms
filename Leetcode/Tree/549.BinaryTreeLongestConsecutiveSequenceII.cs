using System;
using System.Collections.Generic;

public class LongestConsecutiveSolutionII {
    int maxLength=0;    
    public int LongestConsecutive(TreeNode root) {
        DFS(root);
        return maxLength;
    }

    public int[] DFS(TreeNode root)
    {
        if(root == null) return new int[]{0,0} ; 
        int inc=1;
        int decr=1;
        if(root.left !=null )
        {
            int[] left =  DFS(root.left);
            if(root.val == root.left.val+1)
                decr=left[0]+1;
            else if(root.val == root.left.val -1)
                inc=left[1]+1;
        }
        if(root.right !=null )
        {
            int[] right =  DFS(root.right);
            if(root.val == root.right.val+1)
                decr=Math.Max( right[0]+1,decr);
            else if(root.val == root.right.val -1)
                inc=Math.Max(right[1]+1,inc);
        }
        maxLength=Math.Max(decr+inc-1,maxLength);
        return new int[]{decr,inc};        
    }
}