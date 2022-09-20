using System;
using System.Collections.Generic;


public class FindLeavesofBinaryTreeSolution {
    public static List<IList<int>> result;

    public static IList<IList<int>> FindLeaves(TreeNode root) {
        result=new List<IList<int>>();
        getHt(root);        
        return result;
    }
    public static int getHt(TreeNode root) {
        if(root==null) return -1;
        int left=getHt(root.left);
        int right=getHt(root.right);
        int currentHt = 1 + Math.Max(left,right);
        if(currentHt >= result.Count )
        {
            result.Add(new List<int>());
        }
        result[currentHt].Add(root.val);
        return currentHt;
    }
}

// public class FindLeavesofBinaryTreeSolution {
//     public static Dictionary<int,List<int>> test;

//     public static IList<IList<int>> FindLeaves(TreeNode root) {
//         test=new Dictionary<int,List<int>>();
//         List<IList<int>> result=new List<IList<int>>();
//         getHt(root); 
//         foreach (var testList in test)
//         {
//             result.Add(testList.Value);
//         }       
//         return result;
//     }
//     public static int getHt(TreeNode root) {
//         if(root==null) return -1;
//         int left=getHt(root.left);
//         int right=getHt(root.right);
//         int currentHt =1 + Math.Max(left,right);
//         if(!test.ContainsKey(currentHt))
//         {
//             test[currentHt]=new List<int>();
//         }
//         test[currentHt].Add(root.val);
//         return currentHt;
//     }
// }