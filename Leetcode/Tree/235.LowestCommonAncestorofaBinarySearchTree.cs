using System;

public class LowestCommonAncestorSolution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(p.val < root.val && q.val < root.val)
            return LowestCommonAncestor(root.left,p,q);
        else if(p.val > root.val && q.val > root.val)
            return LowestCommonAncestor(root.right,p,q);
        else return root;
    }
    // public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
    //     while(root != null)
    //     {
    //         if(p.val < root.val && q.val < root.val)
    //             root=root.left;
    //         else if(p.val > root.val && q.val > root.val)
    //             root=root.right;
    //         else break;
    //     }
    //     return root;        
    // }
    
}