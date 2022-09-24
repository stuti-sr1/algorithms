using System;
using System.Collections.Generic;

public class FindSmallestRegionSolution {
    public string FindSmallestRegion(IList<IList<string>> regions, string region1, string region2) {
        Dictionary<string,string> map=new Dictionary<string,string>();
        foreach (List<string> region in regions)
        {
            for (int i = 1; i < region.Count; i++)
            {
                map.Add(region[i],region[0]);
            }
        }
        ISet<string> seen= new HashSet<string>();
        while (map.ContainsKey(region1))
        {
            seen.Add(region1);
            region1=map[region1];
        }
        while(map.ContainsKey(region2) && !seen.Contains(region2))
        {
            seen.Add(region2);
            region2=map[region2];
        }
        return region2;
    }
}




// public class FindSmallestRegionSolution {
//     public string FindSmallestRegion(IList<IList<string>> regions, string region1, string region2) {
//         TreeNode root=null;
//         int strLen;
//         int len = regions.Count;
//         IList<string> region=new List<string>();
//         if(regions.Count > 0)
//         {
//             region=regions[0];
//             strLen=region.Count;
//             root=new TreeNode(region[0]);
//             root.left= strLen >=1 ? new TreeNode(region[1]):null;
//             root.right= strLen >=2 ? new TreeNode(region[2]):null;
//         }
//         for (int i = 1; i < len-1; i++)
//         {
//             region=regions[i];
//             strLen=region.Count;
//             TreeNode newRoot=FindLeaves(root,region[0]);
//             if(newRoot !=null)
//             {
//                 if(strLen==1) newRoot.left=new TreeNode(region[1]);
//                 else if(strLen==2){
//                     newRoot.left=new TreeNode(region[1]);
//                     newRoot.right=new TreeNode(region[2]);
//                 }
//             }
//         }
//         TreeNode res = LowestCommonAncestor(root,region1,region2);
//         return res.val;
//     }
//     public TreeNode FindLeaves(TreeNode root,string node)
//     {
//         if(root == null || root.val == node) return root;
//         TreeNode left=FindLeaves(root.left, node);
//         TreeNode right=FindLeaves(root.right, node);
//         if(left!=null && left.val==node) return left;
//         if(right!=null && right.val==node) return right;
//         return null;
//     }
//     public int foundCount=0;
//     public TreeNode LowestCommonAncestor(TreeNode root, string p, string q) {
//         TreeNode res = RecursiveLowestCommonAncestor(root,p,q);
//         return foundCount==2?res:null;
//     }
//     public TreeNode RecursiveLowestCommonAncestor(TreeNode root, string p, string q) {
//         if(root == null) return root;
//         if(root.val == p || root.val == q) 
//         {
//             foundCount++;
//             return root;
//         }
//         TreeNode left=RecursiveLowestCommonAncestor(root.left,p,q);
//         TreeNode right=RecursiveLowestCommonAncestor(root.right,p,q);
//         if(left !=null && right!=null)
//             return root;
//         if(left != null)
//             return left;
//         if(right != null)
//             return right;
//         return null;
//     }
// }
// public class TreeNode {
//        public string val;
//        public TreeNode left;
//        public TreeNode right;
//        public TreeNode(string val, TreeNode left=null, TreeNode right=null) {
//            this.val = val;
//            this.left = left;
//            this.right = right;
//        }
//    }