using System;
using System.Collections.Generic;


public class CombineSolution {
    public static List<IList<int>> output;

    public static IList<IList<int>> Combine(int n, int k) {
        output=new List<IList<int>>();
        backtrack(n,k,new List<int>(),1);
        return output;
    }

    private static void backtrack(int n, int k, List<int> current, int first )
    {
        if(current.Count == k)
        {
            output.Add(new List<int>(current));
        }
        for (int i = first; i <= n; i++)
        {
            current.Add(i);
            backtrack(n,k,current,i+1);
            current.Remove(i);
        }
    }
}