public class islandsAndTreasureSolution {
    // Islands and Treasure
    public void islandsAndTreasure(int[][] grid) {
        Queue<(int, int)> queue = new Queue<(int, int)>();
        int rows = grid.Length;
        int cols = grid[0].Length;

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 0) {
                    queue.Enqueue((i, j));
                }
            }
        }

        int[][] directions = { new int[] { 1, 0 }, new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 0, -1 } };

        while (queue.Count > 0) {
            var (r, c) = queue.Dequeue();
            foreach (var dir in directions) {
                int nr = r + dir[0];
                int nc = c + dir[1];
                if (nr >= 0 && nr < rows && nc >= 0 && nc < cols && grid[nr][nc] == 2147483647) {
                    grid[nr][nc] = grid[r][c] + 1;
                    queue.Enqueue((nr, nc));
                }
            }
        }
    }
}