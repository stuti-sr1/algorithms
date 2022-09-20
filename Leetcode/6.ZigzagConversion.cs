using System;
using System.Collections.Generic;
using System.Text;

public static class ZigzagConversionSolution {
    public static string Convert(string s, int numRows) {
        List<StringBuilder> row=new List<StringBuilder>();
        int len=s.Length;
        if(numRows < 2) return s;
        for (int i = 0; i < numRows; i++)
        {
            row.Add(new StringBuilder());
        }
        bool goingDown=false;
        int currentRow=0;
        foreach (char c in s)
        {
            row[currentRow].Append(c);
            if (currentRow==0 || currentRow== numRows-1)
                goingDown=!goingDown;
            currentRow+=goingDown?1:-1;
        }
        StringBuilder result=new StringBuilder();
        for(int i=0;i<numRows;i++)
        {
            result.Append(row[i]);
        }
        return result.ToString();
    }
}