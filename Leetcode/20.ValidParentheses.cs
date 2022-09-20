using System;
using System.Collections.Generic;

public class IsValidSolution {
    public static bool IsValid(string s) {
        char[] cArray=s.ToCharArray();
        Stack<char> stack=new Stack<char>();
        Dictionary<char,char> map=new Dictionary<char,char>();
        map.Add('(',')');
        map.Add('{','}');
        map.Add('[',']');
        foreach (char item in cArray)
        {
            if(item== '(' || item== '{' || item== '[')
            {
                stack.Push(item);
            }
            else if(item== ')' || item== '}' || item== ']')
            {
                if(stack.Count == 0) return false;
                char t=stack.Pop();
                if(map[t] != item) return false;
                else continue;
            }
        }
        return stack.Count>0? false:true;
    }
}