using System;

namespace _999._Available_Captures_for_Rook
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[,] input1 = new char[,] {
            //    { '.', '.', '.', '.', '.', '.', '.', '.' },
            //    { '.', '.', '.', 'p', '.', '.', '.', '.' },
            //    { '.', '.', '.', 'R', '.', '.', '.', 'p' },
            //    { '.', '.', '.', '.', '.', '.', '.', '.' },
            //    { '.', '.', '.', '.', '.', '.', '.', '.' },
            //    { '.', '.', '.', 'p', '.', '.', '.', '.' },
            //    { '.', '.', '.', '.', '.', '.', '.', '.' },
            //    { '.', '.', '.', '.', '.', '.', '.', '.' } };

            char[][] input = new char[8][]
            {
                new char[]{ '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[]{ '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[]{ '.', '.', '.', 'R', '.', '.', '.', 'p' },
                new char[]{ '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[]{ '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[]{ '.', '.', '.', 'p', '.', '.', '.', '.' },
                new char[]{ '.', '.', '.', '.', '.', '.', '.', '.' },
                new char[]{ '.', '.', '.', '.', '.', '.', '.', '.' }
            };
            Console.WriteLine(NumRookCaptures1(input));
            Console.ReadKey();
        }
               
        public static int NumRookCaptures1(char[][] b)
        {
            for (int i = 0; i < 8; ++i)
                for (int j = 0; j < 8; ++j)
                    if (b[i][j] == 'R') return cap(b, i, j, 0, 1) + cap(b, i, j, 0, -1) + cap(b, i, j, 1, 0) + cap(b, i, j, -1, 0);
            return 0;
        }

        static int cap(char[][] b, int x, int y, int dx, int dy)
        {
            while (x >= 0 && x < b.GetLength(0) && y >= 0 && y < b.GetLength(0) && b[x][y] != 'B')
            {
                if (b[x][y] == 'p') return 1;
                x += dx; y += dy;
            }
            return 0;
        }

        public static int NumRookCaptures(char[][] board)
        {
            int rc = -1, rr = -1;
            for (int m = 0; m < 8; m++)
            {
                for (int n = 0; n < 8; n++)
                {
                    if (board[m][n] == 'R')
                    {
                        rc = n;
                        rr = m;
                        break;
                    }
                }
            }
            int u = rr, s = rr, e = rc, w = rc;
            bool uFlag = true;
            bool sFlag = true;
            bool eFlag = true;
            bool wFlag = true;
            int count = 0;
            while (uFlag || sFlag || eFlag || wFlag)
            {
                //north
                if (u < 0)
                {
                    uFlag = false;
                }
                else if (board[u][rc] == 'p' && uFlag)
                {
                    count++;
                    uFlag = false;
                }
                else if (board[u][rc] == 'B' && uFlag)
                {
                    uFlag = false;
                }
                else
                {
                    u--;
                }

                //south
                if (s > 7)
                {
                    sFlag = false;
                }
                else if (board[s][rc] == 'p' && sFlag)
                {
                    count++;
                    sFlag = false;
                }
                else if (board[s][rc] == 'B' && sFlag)
                {
                    sFlag = false;
                }
                else
                {
                    s++;
                }

                //east
                if (e < 0)
                {
                    eFlag = false;
                }
                else if (board[rr][e] == 'p' && eFlag)
                {
                    count++;
                    eFlag = false;
                }
                else if (board[rr][e] == 'B' && eFlag)
                {
                    eFlag = false;
                }
                else
                {
                    e--;
                }


                //west
                if (w > 7)
                {
                    wFlag = false;
                }
                else if (board[rr][w] == 'p' && wFlag)
                {
                    count++;
                    wFlag = false;
                }
                else if (board[rr][w] == 'B' && wFlag)
                {
                    wFlag = false;
                }
                else
                {
                    w++;
                }
            }

            return count;
        }
    }
}
