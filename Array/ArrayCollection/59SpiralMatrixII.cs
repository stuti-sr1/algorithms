using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _59SpiralMatrixII
    {
        public static int[][] GenerateMatrix(int n)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < n*n; i++)
            {
                list.Add(i+1);
            }           
            return SpiralOrder(list, n);
        }

        private static int[][] SpiralOrder(List<int> list, int n)
        {
            int top = 0;
            int bottom = n - 1;
            int left = 0;
            int right = n - 1;
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new int[n];
            }
            int count = 0;
            while (left <= right && top <= bottom)
            {
                //top run left to right
                for (int i = left; i <= right; i++)
                {
                    matrix[top][i]=list[count++];
                }
                top++;

                //top to bottom
                for (int i = top; i <= bottom; i++)
                {
                    matrix[i][right]=list[count++]; ;
                }
                right--;

                if (!(left <= right && top <= bottom)) break;

                //right to left
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom][i]= list[count++]; 
                }
                bottom--;

                //bottom to top
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i][left]= list[count++];
                }
                left++;

            }
            return matrix;
        }
    }
}
