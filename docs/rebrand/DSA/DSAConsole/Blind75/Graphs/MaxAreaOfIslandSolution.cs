public class MaxAreaOfIslandSolution {
    // Max Area of Island
    public int MaxAreaOfIsland(int[][] grid) {
        int max = 0;

        for(int i=0; i < grid.Length; i++)
            for(int j=0; j < grid[i].Length; j++)
                max = Math.Max(max, MaxArea(grid, i, j));

        return max;        
    }

    int MaxArea(int[][] grid, int i, int j)
    {
        if (i < 0 || i == grid.Length) return 0;
        if (j < 0 || j == grid[i].Length) return 0;

        int c = grid[i][j];

        if (c == 0 || c == -1) return 0;

        grid[i][j] = -1;

        int q = 1;

        q += MaxArea(grid, i + 1, j);
        q += MaxArea(grid, i, j + 1);
        q += MaxArea(grid, i - 1, j);
        q += MaxArea(grid, i, j - 1);

        return q;
    }
}
