public class WordSearchSolution {
    //Word Search
    public bool Exist(char[][] board, string word) {
        /*
        loop each row and each col
        walk each char from the each row
        
        watch boundaries width[col] and height[row]

        if char not equals return false
        else trim target move right one char
        before recursion mark current to alias to avoid overflow
            walk backward col-1
            walk forward col+1
            walk upward row-1
            walk downward row+1
        only one move must be true
        return previous target alias for backtracking
        */
        
        for(int row = 0; row < board.Length; row++)
            for(int col = 0; col < board[row].Length; col++)
                if (Walk(board, row, col, word)) return true;

        return false;
    }

    bool Walk(char[][] board, int row, int col, string target)
    {
        if (row < 0 || row == board.Length) return false;
        if (col < 0 || col == board[row].Length) return false;

        char val = board[row][col];

        if (val != target[0]) return false;

        string newTarget = target.Substring(1);

        board[row][col] = '#'; //avoid overflow

        bool found =
            newTarget.Length == 0 ||
            Walk(board, row, col+1, newTarget) ||
            Walk(board, row+1, col, newTarget) ||
            Walk(board, row, col-1, newTarget) ||
            Walk(board, row-1, col, newTarget);

        board[row][col] = val; //backtrack

        return found;
    }
}
