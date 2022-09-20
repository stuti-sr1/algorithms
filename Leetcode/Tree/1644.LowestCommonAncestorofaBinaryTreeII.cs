using System;

public class LowestCommonAncestorSolutionBTII {
    public int foundCount=0;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        TreeNode res = RecursiveLowestCommonAncestor(root,p,q);
        return foundCount==2?res:null;
    }

    public TreeNode RecursiveLowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null) return root;
        if(root.val == p.val || root.val == q.val) 
        {
            foundCount++;
            return root;
        }
        TreeNode left=RecursiveLowestCommonAncestor(root.left,p,q);
        TreeNode right=RecursiveLowestCommonAncestor(root.right,p,q);
        if(left !=null && right!=null)
            return root;
        if(left != null)
            return left;
        if(right != null)
            return right;
        return null;
    }
}