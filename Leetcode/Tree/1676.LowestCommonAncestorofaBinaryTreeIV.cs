using System;
using System.Collections.Generic;

public class LCASolutionIV {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes) {
        ISet<TreeNode> setMap=new HashSet<TreeNode>();
        foreach (TreeNode item in nodes) setMap.Add(item);
        return FindLCA(root,setMap);
        
    }
    public TreeNode FindLCA(TreeNode root,ISet<TreeNode> nodes)
    {
        if(root == null) return null;
        if(nodes.Contains(root)) return root;
        TreeNode left=FindLCA(root.left,nodes);
        TreeNode right=FindLCA(root.right,nodes);
        if(left != null && right != null) return root;
        return left!=null? left:right;
    }
}