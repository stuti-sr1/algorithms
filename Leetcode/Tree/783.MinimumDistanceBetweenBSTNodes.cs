using System;
using System.Collections.Generic;

public class MinDiffInBSTSolution { 
    public int minValue=int.MaxValue;
    public int prev=int.MaxValue;
    public int MinDiffInBST(TreeNode root) {
        Inorder(root);
        return minValue;
    }

    public void Inorder(TreeNode root)
    {
        if(root!=null)
        {
            Inorder(root.left);
            int diff=Math.Abs(root.val-prev);
            if(diff <= minValue) minValue=diff;
            prev=root.val;            
            Inorder(root.right);
        }
        return;
    }


    // public List<int> list;
    // public int MinDiffInBST(TreeNode root) {
    //     list=new List<int>();
    //     int minValue=int.MaxValue;
    //     Inorder(root);
    //     for (int i = 1; i < list.Count; i++)
    //     {
    //         minValue = minValue > Math.Abs(list[i]-list[i-1]) ? Math.Abs(list[i]-list[i-1]):minValue; 
    //     }
    //     return minValue;
    // }

    // public void Inorder(TreeNode root)
    // {
    //     if(root!=null)
    //     {
    //         Inorder(root.left);
    //         list.Add(root.val);
    //         Inorder(root.right);
    //     }
    // }
}