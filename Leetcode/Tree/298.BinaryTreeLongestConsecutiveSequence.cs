using System;
using System.Collections.Generic;


public class LongestConsecutiveSolution {
    public int leftCount=1;
    public int rightCount=1;
    public int maxCount=0;
    public int LongestConsecutive(TreeNode root) {
        Inorder(root);
        return maxCount;
    }
    public void Inorder(TreeNode root)
    {
        if(root!=null)
        {
            if(root.left !=null )
            {
                if(root.val+1 == root.left.val) leftCount++;                
                else leftCount=0;
                maxCount=Math.Max(maxCount,leftCount);
                Inorder(root.left);                
            }
            if(root.right !=null )
            {
                if(root.val+1 == root.right.val) rightCount++;                
                else rightCount=0;
                maxCount=Math.Max(maxCount,rightCount);
                Inorder(root.right);                
            }
        }
    }
}