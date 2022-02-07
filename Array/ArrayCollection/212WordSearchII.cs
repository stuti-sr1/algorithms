using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCollection
{
    public static class _212WordSearchII
    {
        public static IList<string> FindWords(char[][] board, string[] words)
        {            
            IList<string> result = new List<string>();
            bool res;
            foreach (string word in words)
            {
                res = Exist(board, word);
                if (res)
                {
                    result.Add(word);
                }
            }
            return result;
        }
        private static bool Exist(char[][] board, string word)
        {
            bool[,] visit = new bool[board.Length, board[0].Length];
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    visit[i, j] = false;
                }
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (word[0] == board[i][j] && DFS(board, word, 0, i, j, visit))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private static bool DFS(char[][] board, string word, int len, int i, int j, bool[,] visit)
        {
            if (len == word.Length) return true;
            if (i < 0 || j < 0 || i >= board.Length || j >= board[0].Length) return false;
            if (word[len] != board[i][j] || visit[i, j] == true) return false;
            visit[i, j] = true;
            if (DFS(board, word, len + 1, i + 1, j, visit) ||
                DFS(board, word, len + 1, i, j + 1, visit) ||
                DFS(board, word, len + 1, i - 1, j, visit) ||
                DFS(board, word, len + 1, i, j - 1, visit))
            {
                return true;
            }
            visit[i, j] = false;
            return false;
        }
    }
}
