using System;

public class IsSubtreeSolution {

    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        return Transversal(root,subRoot);
    }

    public bool RecursiveIsSubtree(TreeNode root, TreeNode subRoot) {
        if(root == null && subRoot==null) return true;
        else if(root == null || subRoot==null) return false;
        else if(root.val != subRoot.val) return false;
        else  {
            return RecursiveIsSubtree(root.left,subRoot.left) && RecursiveIsSubtree(root.right,subRoot.right);
        }
    }

    public bool Transversal(TreeNode root, TreeNode subRoot) {
        return (root!=null && (RecursiveIsSubtree(root,subRoot) || Transversal(root.left,subRoot) || Transversal(root.right,subRoot)));
    }
}