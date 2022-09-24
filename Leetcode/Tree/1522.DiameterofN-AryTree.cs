using System;
using System.Collections.Generic;


public class DiameterSolution {
    public int diameter=0;
    public int Diameter(Node root) {
        RecursiveDiameter(root);
        return diameter;
    }

    public int RecursiveDiameter(Node root) {
        int maxHt1=0;
        int maxHt2=0;
        if(root == null || root.children.Count ==0) return 0;
        foreach (Node child in root.children)
        {
            int parentHt=RecursiveDiameter(child)+1;
            if(maxHt1 < parentHt) {
                maxHt2=maxHt1;
                maxHt1=parentHt;
            }
            else if(maxHt2 < parentHt)
                maxHt2=parentHt;   
            int dist=maxHt1+maxHt2;
            diameter=Math.Max(diameter,dist);        
        }
        return maxHt1;
    }
    // Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;
    
    public Node() {
        val = 0;
        children = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        children = new List<Node>();
    }
    
    public Node(int _val, List<Node> _children) {
        val = _val;
        children = _children;
    }
}
}


