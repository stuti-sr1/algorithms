using System;

public static class MaxPathSumSolution {
    public static int max=Int32.MinValue;
    public static int MaxPathSum(TreeNode root) {
        return RecursiveMaxPathSum(root);       
    }
    public static int RecursiveMaxPathSum(TreeNode root)
    {
        if(root == null) return 0;
        int left = Math.Max( RecursiveMaxPathSum(root.left),0);
        int right= Math.Max( RecursiveMaxPathSum(root.right),0);
        int newMax=root.val+left+right;
        max=Math.Max(max,newMax);
        return root.val+Math.Max(left,right);
    }
}