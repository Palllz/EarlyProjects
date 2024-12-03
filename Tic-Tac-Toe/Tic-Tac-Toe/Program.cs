
   string IsSolved(int[,] board)
    {
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0) //row check
                return $"Player {board[i, 0]} win";
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0) //column check
                return $"Player {board[0, i]} win";
        }
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0) //main diagonal check
            return $"Player {board[0, 0]} win";
        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0) //minor diagonal check
            return $"Player {board[0, 2]} win";
        for (int i = 0; i < 3; i++)     //empty spots check
            for (int j = 0; j < 3; j++)
                if (board[i, j] == 0)
                    return "Board is not yet finished";
        return "It's a draw";
    }
int[,] board = new int[,] { { 1, 1, 1 }, { 0, 2, 2 }, { 0, 0, 0 } };
Console.WriteLine(IsSolved(board)); 
