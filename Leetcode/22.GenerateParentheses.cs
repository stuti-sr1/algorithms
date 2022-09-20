using System;
using System.Collections.Generic;
using System.Text;

public class GenerateParenthesisSolution {
    public static List<string> output;
    public static IList<string> GenerateParenthesis(int n)
    {
        output=new List<string>();
        StringBuilder current=new StringBuilder();
        backtrack(current,0,0,n);
        foreach (string items in output)
        {
            Console.WriteLine(items);
        }
        return output;   
    }
    public static void backtrack(StringBuilder current,int open ,int close, int max)
    {
        if(current.Length==max*2)
        {
            output.Add(current.ToString());
        }
        if(open < max)
        {
            current.Append("(");
            backtrack(current,open+1,close,max);
            current.Remove(current.Length-1,1);
        }
        if(close < open)
        {
            current.Append(")");
            backtrack(current,open,close+1,max);
            current.Remove(current.Length-1,1);
        }
    }
    // {

    // public static ISet<string> stringMap;
    // public static List<string> output;
    // public static IList<string> GenerateParenthesis(int n) {
    //     output=new List<string>();
    //     stringMap=new HashSet<string>();
    //     List<char> nums=new List<char>();
    //     for (int i = 0; i < n; i++)
    //     {
    //         nums.Add('(');
    //         nums.Add(')');
    //     }
    //     StringBuilder current=new StringBuilder();
    //     backtrack(nums,n*2,current,0);
    //     foreach (string items in output)
    //     {
    //         Console.WriteLine(items);
    //     }
    //     return output;        
    // }

    // public static void backtrack(List<char> nums, int n , StringBuilder current,int index )
    // {
    //     if(index == n)
    //     {
    //         if(stringMap.Add(current.ToString()) && IsValid(current.ToString()))
    //         {
    //             output.Add(current.ToString());
    //         }
    //         return;
    //     }
    //     for (int i = index; i < n; i++)
    //     {
    //         current.Append(nums[i]);
    //         backtrack(nums,n,current,index+1);
    //         current.Remove(current.Length-1,1);
    //     }
    // }

    // public static bool IsValid(string s) {
    //     char[] cArray=s.ToCharArray();
    //     Stack<char> stack=new Stack<char>();        
    //     foreach (char item in cArray)
    //     {
    //         if(item== '(' )
    //         {
    //             stack.Push(item);
    //         }
    //         else if(item== ')' )
    //         {
    //             if(stack.Count == 0) return false;
    //             char t=stack.Pop();
    //             if(item!= ')') return false;
    //             else continue;
    //         }
    //     }
    //     return stack.Count>0? false:true;
    // }
}