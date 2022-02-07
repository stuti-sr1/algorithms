using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _79WordSearch
    {
        public static bool Exist(char[][] board, string word)
        {
            int r = board.Length;
            int c = board[0].Length;
            bool[,] visited = new bool[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    visited[i, j] = false;
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (word[0] == board[i][j] && DFS(board, word, 0, i, j, visited))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool DFS(char[][] board, string word, int len, int i, int j, bool[,] visited)
        {
            if (word.Length == len)
                return true;
            if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length)
                return false;
            if (word[len] != board[i][j] || visited[i, j] == true)
                return false;
            visited[i, j] = true;
            if (DFS(board, word, len + 1, i + 1, j, visited) ||
                DFS(board, word, len + 1, i, j + 1, visited) ||
                DFS(board, word, len + 1, i - 1, j, visited) ||
                DFS(board, word, len + 1, i, j - 1, visited))
            {
                return true;
            }
            visited[i, j] = false;
            return false;
        }





        //private static int[] dx = { 0, 0, 1, -1 };
        //private static int[] dy = { 1, -1, 0, 0 };

        //public static bool Exist(char[][] board, string word)
        //{
        //    int r = board.Length;
        //    int c = board[0].Length;
        //    if (board == null || board.Length == 0 || word == null || word == string.Empty || word.Length > r * c)
        //        return false;

        //    bool[,] visited = new bool[r, c];

        //    for (int i = 0; i < r; i++)
        //    {
        //        for (int j = 0; j < c; j++)
        //        {
        //            if (word[0] == board[i][j] && DFS(board, word, 0, i, j, visited, r, c))
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;
        //}

        //private static bool DFS(char[][] board, string word, int len, int i, int j, bool[,] visited, int r, int c)
        //{
        //    if (board[i][j] == word[len])
        //    {
        //        if (len == word.Length - 1) return true;
        //        visited[i, j] = true;
        //        for (int k = 0; k < 4; k++)
        //        {
        //            int newx = i + dx[k];
        //            int newy = j + dy[k];

        //            if (newx > -1 && newx < r && newy > -1 && newy < c && visited[newx, newy] == false && DFS(board, word, len + 1, newx, newy, visited, r, c))
        //            {
        //                return true;
        //            }
        //            visited[i, j] = false;
        //        }
        //    }
        //    return false;
        //}

        //public static bool Exist(char[][] board, string word)
        //{
        //    int r = board.Length;
        //    int c = board[0].Length;
        //    bool[][] isvisited = new bool[r][];
        //    for (int i = 0; i < r; i++)
        //    {   
        //        isvisited[i] = new bool[c];
        //        for (int j = 0; j < c; j++)
        //        {
        //            isvisited[i][j] = false;
        //        }
        //    }
        //    int[] d1 = { 0, 1 };
        //    int[] d2 = { 1, 0 };
        //    int[] d3 = { 0, -1 };
        //    int[] d4 = { -1, 0 };
        //    int[][] direction = { d1, d2, d3, d4 };
        //    int r0;
        //    int c0;
        //    bool res = CheckStartPoint(board, r, c, out r0, out c0, isvisited, word);
        //    if(!res)
        //    {
        //        return false;
        //    }
        //    int rStart = r0;
        //    int cStart = c0;
        //    int count = 1;
        //    isvisited[rStart][cStart] = true;
        //    while (count < word.Length)
        //    {
        //        if ((rStart + direction[0][0]) >= 0 && (rStart + direction[0][0]) < r && (cStart + direction[0][1]) >= 0 && (cStart + direction[0][1]) < c && isvisited[(rStart + direction[0][0])][(cStart + direction[0][1])] == false && word[count] == board[(rStart + direction[0][0])][(cStart + direction[0][1])])
        //        {
        //            rStart += direction[0][0];
        //            cStart += direction[0][1];
        //            isvisited[rStart][cStart] = true;
        //            count++;
        //        }
        //        else if ((rStart + direction[1][0]) >= 0 && (rStart + direction[1][0]) < r && (cStart + direction[1][1]) >= 0 && (cStart + direction[1][1]) < c && isvisited[(rStart + direction[1][0])][(cStart + direction[1][1])] == false && word[count] == board[(rStart + direction[1][0])][(cStart + direction[1][1])])
        //        {
        //            rStart += direction[1][0];
        //            cStart += direction[1][1];
        //            isvisited[rStart][cStart] = true;
        //            count++;
        //        }
        //        else if ((rStart + direction[2][0]) >= 0 && (rStart + direction[2][0]) < r && (cStart + direction[2][1]) >= 0 && (cStart + direction[2][1]) < c && isvisited[(rStart + direction[2][0])][(cStart + direction[2][1])] == false && word[count] == board[(rStart + direction[2][0])][(cStart + direction[2][1])])
        //        {
        //            rStart += direction[2][0];
        //            cStart += direction[2][1];
        //            isvisited[rStart][cStart] = true;
        //            count++;
        //        }
        //        else if ((rStart + direction[3][0]) >= 0 && (rStart + direction[3][0]) < r && (cStart + direction[3][1]) >= 0 && (cStart + direction[3][1]) < c && isvisited[(rStart + direction[3][0])][(cStart + direction[3][1])] == false && word[count] == board[(rStart + direction[3][0])][(cStart + direction[3][1])])
        //        {
        //            rStart += direction[3][0];
        //            cStart += direction[3][1];
        //            isvisited[rStart][cStart] = true;
        //            count++;
        //        }
        //        else
        //        {
        //            res = CheckStartPoint(board, r, c, out r0, out c0, isvisited, word);
        //            if (res == true)
        //            {
        //                rStart = r0;
        //                cStart = c0;
        //                count = 1;
        //                isvisited[rStart][cStart] = true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return true;
        //}

        //private static bool CheckStartPoint(char[][] board, int r, int c, out int r0, out int c0, bool[][] isvisited, string word)
        //{
        //    for (int i = 0; i < r; i++)
        //    {
        //        for (int j = 0; j < c; j++)
        //        {
        //            if (word[0] == board[i][j] && isvisited[i][j] == false)
        //            {
        //                r0 = i;
        //                c0 = j;
        //                return true;
        //            }
        //        }
        //    }
        //    r0 = -1;
        //    c0 = -1;
        //    return false;
        //}
    }
}
