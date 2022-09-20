using System;
using System.Collections.Generic;

public class DeepestLeavesSumSolution {
    public static int DeepestLeavesSum(TreeNode root) {
        Queue<TreeNode> q=new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(null);
        int sum=0;
        while (q.Count>0)
        {
            TreeNode val=q.Dequeue();            
            if(val != null)
            {
                sum+=val.val;
                if(val.left !=null)
                    q.Enqueue(val.left);
                if(val.right !=null)
                    q.Enqueue(val.right);
            }else{
                if(q.Count==0)
                    return sum;
                else 
                {
                    sum=0;
                    q.Enqueue(null);
                }
            }
        }
        return sum;        
    }
}