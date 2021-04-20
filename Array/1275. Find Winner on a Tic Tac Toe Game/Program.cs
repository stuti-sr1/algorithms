using System;

namespace _1275._Find_Winner_on_a_Tic_Tac_Toe_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] moves = new int[5][];
            moves[0] = new int[] { 0, 0 };
            moves[1] = new int[] { 2, 0 };
            moves[2] = new int[] { 1, 1 };
            moves[3] = new int[] { 2, 1 };
            moves[4] = new int[] { 2, 2 };
            Console.WriteLine(Tictactoe(moves));
            Console.ReadKey();
        }
        public static string Tictactoe(int[][] moves)
        {
            int n = 3;
            char[][] board = new char[n][];
            for (int i = 0; i < n; i++)
            {
                board[i] = new char[n];
            }
            for (int i = 0; i < moves.Length; i++)
            {
                int r = moves[i][0];
                int c = moves[i][1];

                if ((i & 1) == 0)
                {
                    board[r][c] = 'X';
                    bool t = DidWin(board, 'X', r, c);
                    if (t) return "A";
                }
                else
                {
                    board[r][c] = 'O';
                    bool t = DidWin(board, 'O', r, c);
                    if (t) return "B";
                }
            }
            if (moves.Length == n * n)
            {
                return "Draw";
            }
            else return "Pending";
        }

        public static bool DidWin(char[][] board, char player, int row, int col)
        {
            int n = board.Length;
            bool didPlayerWin = true;
            //check same row
            for (int i = 0; i < board.Length; i++)
            {
                if (board[row][i] != player) didPlayerWin = false;
            }
            if (didPlayerWin) return true;
            didPlayerWin = true;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][col] != player) didPlayerWin = false;
            }
            if (didPlayerWin) return true;
            didPlayerWin = true;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][i] != player) didPlayerWin = false;
            }
            if (didPlayerWin) return true;
            didPlayerWin = true;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i][n - i - 1] != player) didPlayerWin = false;
            }
            return didPlayerWin;
        }
    }
}
