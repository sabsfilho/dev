public class NumIslandsSolution {
    public int NumIslands(char[][] grid) {
        int q = 0;

        for(int i=0; i < grid.Length; i++)
            for(int j=0; j < grid[i].Length; j++)        
                q += NumIslands(grid, i, j);
        
        return q;
    }

    int NumIslands(char[][] grid, int i, int j) {

        if (i < 0 || i == grid.Length) return 0;
        if (j < 0 || j == grid[i].Length) return 0;
        
        char c = grid[i][j];

        if (c == '0' || c == '#') return 0;

        grid[i][j] = '#';

        NumIslands(grid, i + 1, j);
        NumIslands(grid, i, j + 1);
        NumIslands(grid, i - 1, j);
        NumIslands(grid, i, j - 1);

        return 1;
    }
}
