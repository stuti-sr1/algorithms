using System;

public class InvertTreeSolution {
    public TreeNode InvertTree(TreeNode root) { 
        return RecursiveInvertTree(root);   
    }
    public TreeNode RecursiveInvertTree(TreeNode root)
    {
        if(root == null) return null;
        TreeNode right=RecursiveInvertTree(root.right);
        TreeNode left=RecursiveInvertTree(root.left);
        root.left=right;
        root.right=left;
        return root;
    }
}