using System;


public class IsValidBSTSolution {
    // public bool IsValidBST(TreeNode root) {
    //    return RecursiveIsValidBST(root,null,null);        
    // }
    // public bool RecursiveIsValidBST(TreeNode root,TreeNode min,TreeNode max) { 
    //     if(root == null) return true;
    //     if((min!=null && root.val <= min.val) || (max!=null && root.val>=max.val)) return false;
    //     return RecursiveIsValidBST(root.left,min,root) && RecursiveIsValidBST(root.right,root,max);
    // }

    
//min and max value
    public bool IsValidBST(TreeNode root) {
       return RecursiveIsValidBST(root,null,null);        
    }
    public bool RecursiveIsValidBST(TreeNode root,int? min,int? max) { 
        if(root == null) return true;
        if((min!=null && root.val <= min) || (max!=null && root.val>=max)) return false;
        return RecursiveIsValidBST(root.left,min,root.val) && RecursiveIsValidBST(root.right,root.val,max);
    }



    //Inorder
    public TreeNode prev=null;
    public bool IsValidBSTI(TreeNode root) {
       return RecursiveIsValidBSTI(root);        
    }
    public bool RecursiveIsValidBSTI(TreeNode root) { 
        if(root == null) return true;
        if(!RecursiveIsValidBSTI(root.left) || (prev!=null && prev.val >= root.val)) return false;
        prev=root;
        return RecursiveIsValidBSTI(root.right); 
    }
}