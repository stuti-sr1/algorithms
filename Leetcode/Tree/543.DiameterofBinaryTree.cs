using System;


public class DiameterOfBinaryTreeSolution {
    public int maxHt=0;
    public int DiameterOfBinaryTree(TreeNode root) {
        GetHeight(root,0);
        return maxHt;        
    }

    public int GetHeight(TreeNode root,int ht) {
        if(root == null) return 0;
        int leftHt=GetHeight(root.left,ht);
        int rightHt=GetHeight(root.right,ht);
        int newHt= leftHt+rightHt;
        maxHt = maxHt < newHt ? newHt:maxHt;
        return Math.Max(leftHt,rightHt) +1;        
    }
}