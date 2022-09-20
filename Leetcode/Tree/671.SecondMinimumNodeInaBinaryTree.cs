using System;
using System.Collections.Generic;

public class FindSecondMinimumValueSolution {

     public int FindSecondMinimumValue(TreeNode root) {
        ISet<int> map=new HashSet<int>();
        Inorder(root,map);
        long firstMin=long.MaxValue;
        long secondMin=long.MaxValue;
        foreach (int item in map)
        {
            if(firstMin > item)
            {
                secondMin=firstMin;
                firstMin=item;
            }
            else if(secondMin > item)
            {
                secondMin=item;
            }
        }
        return secondMin !=long.MaxValue? (int)secondMin:-1;
    }

    public void Inorder(TreeNode root, ISet<int> map)
    {
        if(root !=null )
        {
            map.Add(root.val);
            Inorder(root.left,map);
            Inorder(root.right,map);
        }
    }
}