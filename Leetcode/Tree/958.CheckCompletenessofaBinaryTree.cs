using System;
using System.Collections.Generic;

public class IsCompleteTreeSolution {
    public bool IsCompleteTree(TreeNode root) {        
        Queue<TreeNode> queue=new Queue<TreeNode>();
        int countNull=0;
        queue.Enqueue(root);
        while(queue.Count > 0)
        {
            TreeNode newRoot=queue.Dequeue();
            if(newRoot != null)
            {
                if(countNull>0) return false;
                if(newRoot.left !=null)  queue.Enqueue(root.left);
                else queue.Enqueue(null);
                if(newRoot.right !=null)  queue.Enqueue(root.right);                
                else queue.Enqueue(null);
            }
            else 
            {
                countNull++;
            }
        }
        return true;
    }
}