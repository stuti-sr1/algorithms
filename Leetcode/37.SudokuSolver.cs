using System;

public class SolveSudokuSolution {
    public static void SolveSudoku(char[][] board) {
        if(board==null || board.Length == 0) return;
        Solve(board);
    }

    private static bool Solve(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[0].Length; j++)
            {
                if(board[i][j]=='.')
                {
                    for(char k = '1'; k <= '9'; k++)
                    {
                        if(IsValid(board,i,j,k))
                        {
                            board[i][j]=k;                        
                            if(Solve(board))
                                return true;
                            board[i][j]='.';
                        }
                    }
                    return false;
                }
            }            
        }
        return true;
    }

    private static bool IsValid(char[][] board,int r, int c, int k)
    {
        int row=3*(r/3);
        int col=3*(c/3);
        for (int i = 0; i < 9; i++)
        {
            if( board[r][i] == k || board[i][c] == k) return false;
            if(board[row+i/3][col+i%3] == k ) return false;
        }
        return true;
    }
}