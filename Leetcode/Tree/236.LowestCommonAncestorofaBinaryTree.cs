using System;

public class LowestCommonAncestorBTSolution {

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return RecursiveLowestCommonAncestorBT(root,p,q);             
    }

    public TreeNode RecursiveLowestCommonAncestorBT(TreeNode root, TreeNode p, TreeNode q) {        
        if(root == null) return root;
        if(root.val == p.val || root.val == q.val) return root;                  
        TreeNode left=RecursiveLowestCommonAncestorBT(root.left,p,q);
        TreeNode right=RecursiveLowestCommonAncestorBT(root.right,p,q);
        if(left!=null && right!=null)
        {
            return root;
        }
        else if(left!=null)
        {
            return left;
        }
        else if(right!=null)
        {
            return right;
        } 
        return null;          
    }
}