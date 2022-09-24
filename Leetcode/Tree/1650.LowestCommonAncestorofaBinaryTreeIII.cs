using System;
using System.Collections.Generic;

public class LowestCommonAncestorSolutionBTIII {
    ISet<Node> mapSet=new HashSet<Node>();
    Node res=null;
    public Node LowestCommonAncestor(Node p, Node q) 
    {        
        DFS(p);
        return FindLCA(q);
    }
    public void DFS(Node root) 
    {
        while(root!=null)
        {
            mapSet.Add(root);
            root=root.parent;
        } 
        return;
    }    
    public Node FindLCA(Node root) 
    {
        while(root!=null)
        {
            if(mapSet.Contains(root))
            {
                res = root;
                break;
            }
            else root=root.parent;
        } 
        return res;
    }
    public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
}


// public class LowestCommonAncestorSolutionBTIII {
//     public List<Node> pList;
//     public List<Node> qList;

//     public Node LowestCommonAncestor(Node p, Node q) 
//     {        
//         pList= RecursiveLowestCommonAncestor(p);
//         qList= RecursiveLowestCommonAncestor(q);
//         Dictionary<int,Node> map=new Dictionary<int,Node>();
//         foreach (Node item in pList)
//         {
//             map.Add(item.val,item);
//         }
//         foreach (Node item in qList)
//         {
//             if(!map.ContainsKey(item.val)) continue;
//             else
//                 return map[item.val];
//         }
//         return null;
//     }

//     public List<Node> RecursiveLowestCommonAncestor(Node root) 
//     {
//         List<Node> list=new List<Node>();
//         while(root!=null)
//         {
//             list.Add(root);
//             root=root.parent;
//         } 
//         return list;
//     }
// }
