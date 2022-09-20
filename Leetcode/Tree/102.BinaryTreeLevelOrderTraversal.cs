using System;
using System.Collections.Generic;

public static class LevelOrderSolution {
    public static IList<IList<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> queue=new Queue<TreeNode>();
        IList<IList<int>> result=new List<IList<int>>();
        if(root == null) return result;
        queue.Enqueue(root);
        queue.Enqueue(null);
        List<int> collection=new List<int>();
        while (queue.Count >0)
        {
            TreeNode newRoot=queue.Dequeue();
            if(newRoot !=null)
            {
                collection.Add(newRoot.val);
                if(newRoot.left != null)
                    queue.Enqueue(newRoot.left);
                if(newRoot.right != null)
                    queue.Enqueue(newRoot.right);
            }
            else
            {
                if(collection.Count >0)
                    result.Add(collection);
                queue.Enqueue(null);
                if(queue.Count>0 && queue.Peek() == null) return result;
                collection=new List<int>();
            }
        }
        return result;
    }
}