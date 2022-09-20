using System;
using System.Collections.Generic;

public static class Codec {

    public static string serialize(TreeNode root) {
        return RecursiveEncoding(root,string.Empty);
    }
    public static TreeNode deserialize(string data) {
        string[] dataList=data.Split(",");
        List<string> list=new List<string>(dataList);
        TreeNode t=RecursiveDecoding(list);
        return t;
    }
    public static string RecursiveEncoding(TreeNode root, string str) {
        if(root == null) return str+="null,";
        str+=root.val+",";
        str=RecursiveEncoding(root.left,str);
        str=RecursiveEncoding(root.right,str);
        return str;
    }
    public static TreeNode RecursiveDecoding(List<string> data) {
        if(data.Count == 0) return null;
        if(data[0] == "null"){
            data.RemoveAt(0);
            return null;
        }
        TreeNode newNode = new TreeNode(Int32.Parse(data[0]));
        data.RemoveAt(0);
        newNode.left=RecursiveDecoding(data);
        newNode.right=RecursiveDecoding(data);
        return newNode;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));

