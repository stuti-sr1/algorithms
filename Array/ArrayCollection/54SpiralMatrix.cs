using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _54SpiralMatrix
    {
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> res = new List<int>();
            int top = 0;
            int bottom = matrix.Length - 1;
            int left = 0;
            int right = matrix[0].Length - 1;
            while (left <= right && top <= bottom)
            {
                //top run left to right
                for (int i = left; i <= right; i++)
                {
                    res.Add(matrix[top][i]);
                }
                top++;

                //top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    res.Add(matrix[i][right]);
                }
                right--;

                if (!(left <= right && top <= bottom)) break;

                //right to left
                for (int i = right; i >= left; i--)
                {
                    res.Add(matrix[bottom][i]);
                }
                bottom--;

                //bottom to top
                for (int i = bottom; i >= top; i--)
                {
                    res.Add(matrix[i][left]);
                }
                left++;
                
            }
            return res;
        }

        //my way 

        public static IList<int> SpiralOrder1(int[][] matrix)
        {
            IList<int> res = new List<int>();
            int r = matrix.Length;
            int c = matrix[0].Length;
            int count = 1;
            int i = 0;
            int j = 0;
            int cLimit = 0;
            int rLimit = 1;
            int len = c * r;
            while (res.Count < len)
            {
                if (count % 4 == 1)
                {
                    while (j < c)
                    {
                        res.Add(matrix[i][j++]);
                    }
                    i++;
                    j = c - 1;
                }
                else if (count % 4 == 2)
                {
                    while (i < r)
                    {
                        res.Add(matrix[i++][j]);
                    }
                    j--;
                    i = r - 1;
                }
                else if (count % 4 == 3)
                {
                    while (j >= cLimit)
                    {
                        res.Add(matrix[i][j--]);
                    }
                    i--;
                    j = cLimit;
                }
                else if (count % 4 == 0)
                {
                    while (i >= rLimit)
                    {
                        res.Add(matrix[i--][j]);
                    }
                    i = rLimit;
                    j++;
                }
                if (count % 4 == 0)
                {
                    r--;
                    c--;
                    cLimit++;
                    rLimit++;
                }
                count++;
            }
            return res;
        }
    }
}
