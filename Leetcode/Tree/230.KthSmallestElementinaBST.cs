using System;
using System.Collections.Generic;

public class KthSmallestSolution {

    public int res=int.MinValue;
    public int i=0;
    public bool found=false;
    public int KthSmallest(TreeNode root, int k) {   
        Inorder(root,k);
        return res;
    }
    public int Inorder(TreeNode root,int k) {
        if(root != null && !found) {
            Inorder(root.left,k);
            i++;
            if(i==k) 
            { 
                found=true;
                res=root.val;
            }
            Inorder(root.right,k);
        }
        return res;
    }

    // public List<int> list;
    // public int KthSmallest(TreeNode root, int k) {   
    //     list=new List<int>();     
    //     Inorder(root);
    //     return list[k-1];
    // }
    // public void Inorder(TreeNode root) {
    //     if(root != null) {
    //         Inorder(root.left);
    //         list.Add(root.val);
    //         Inorder(root.right);
    //     }
    // }
}



    // public int Inorder(TreeNode root, int k) {
    //     if(root == null) return int.MinValue;
    //     Inorder(root.left,k);
    //     Console.WriteLine(root.val+"    "+k--);
    //     if(k==0) 
    //     { 
    //         Console.WriteLine(root.val+"    "+k--);
    //         return root.val;
    //     }
    //     Inorder(root.right,k);
    // }