using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class GameofLife
    {
        //inplace
        public static void GameOfLife1(int[][] board)
        {
            int r = board.Length;
            int c = board[0].Length;
            int[] d1 = { -1, -1 };
            int[] d2 = { -1, 0 };
            int[] d3 = { -1, 1 };
            int[] d4 = { 1, -1 };
            int[] d5 = { 1, 0 };
            int[] d6 = { 1, 1 };
            int[] d7 = { 0, -1 };
            int[] d8 = { 0, 1 };
            int[][] direction = { d1, d2, d3, d4, d5, d6, d7, d8 };
            int count;
            int x; int y;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    count = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        x = i + direction[k][0];
                        y = j + direction[k][1];
                        if (x >= 0 && x < r && y >= 0 && y < c)
                        {
                            if (board[x][y] % 2 == 1)
                            {
                                count++;
                            }
                        }

                    }
                    if (count >= 0 && (count < 2 || count > 3)) board[i][j] = 0 * 10 + board[i][j] % 2;
                    else if (count == 3) board[i][j] = 1 * 10 + board[i][j] % 2;
                    else if (count == 2) board[i][j] = board[i][j] * 10 + board[i][j] % 2;
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    int t = board[i][j] / 10;
                    board[i][j] = t;
                }
            }
        }


        //using O((m*n) space

        public static void GameOfLife2(int[][] board)
        {
            int r = board.Length;
            int c = board[0].Length;
            int[] d1 = { -1, -1 };
            int[] d2 = { -1, 0 };
            int[] d3 = { -1, 1 };
            int[] d4 = { 1, -1 };
            int[] d5 = { 1, 0 };
            int[] d6 = { 1, 1 };
            int[] d7 = { 0, -1 };
            int[] d8 = { 0, 1 };
            int[][] direction = { d1, d2, d3, d4, d5, d6, d7, d8 };
            int count;
            int[][] ans = new int[r][];
            for (int i = 0; i < r; i++)
            {
                ans[i] = new int[c];
            }
            int x; int y;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    count = 0;
                    for (int k = 0; k < 8; k++)
                    {
                        x = i + direction[k][0];
                        y = j + direction[k][1];
                        if (x >= 0 && x < r && y >= 0 && y < c)
                        {
                            if (board[x][y] == 1)
                            {
                                count++;
                            }
                        }
                    }
                    if (count >= 0 && (count < 2 || count > 3)) ans[i][j] = 0;
                    else if (count == 3) ans[i][j] = 1;
                    else if (count == 2) ans[i][j] = board[i][j];
                }
            }
            Array.Copy(ans, board, board.Length);
        }

    }
}
