public class PacificAtlanticSolution {
    // Pacific Atlantic Water Flow
    public List<List<int>> PacificAtlantic(int[][] heights) {
        /*
        cross pacific and atlantic good coordinates

        col = 0 and row = 0 => pacific
        col = last and row = last => atlantic

        use dfs row, column, previous height
            if visited or out of bounds do nothing
            if current height < previous height do nothing
            add row, col to visited
            cross dfs among 4 steps as left, right, up, dowm

        set pacific and atlantic course good coordinates

        iterate each column
            last = rows - 1
            dfs 0, column, pacific, heigths[0][column]
            dfs last, column, atlantic, heights[last][column]

        iterate each row
            last = cols - 1
            dfs row, 0, pacific, heights[row][0]
            dfs row, last, atlantic, heights[row][last]
        
        [O(row * col)]
        iterate row
            iterate col
                if row,col in pacific and row,col in atlantic
                    add results
        
        return results



        */

        var lst = new List<List<int>>();
        if (heights == null || heights.Length == 0) return lst;

        var pacific = new HashSet<string>();
        var atlantic = new HashSet<string>();

        int rowLen = heights.Length - 1;
        int colLen = heights[0].Length - 1;

        for(int col = 0; col <= colLen; col++)
        {
            PacificAtlantic(heights, 0, col, heights[0][col], pacific);
            PacificAtlantic(heights, rowLen, col, heights[rowLen][col], atlantic);
        }

        for(int row = 0; row <= rowLen; row++)
        {
            PacificAtlantic(heights, row, 0, heights[row][0], pacific);
            PacificAtlantic(heights, row, colLen, heights[row][colLen], atlantic);
        }

        for(int col = 0; col <= colLen; col++)
            for(int row = 0; row <= rowLen; row++)
            {
                string key = string.Concat(row,"-",col);
                if (pacific.Contains(key) && atlantic.Contains(key))
                    lst.Add(new List<int>{ row, col });
            }

        return lst;
    }

    void PacificAtlantic(int[][] heights, int row, int col, int previousHeight, HashSet<string> visited)
    {
        if (row < 0 || row == heights.Length) return;
        if (col < 0 || col == heights[row].Length) return;

        int currentHeight = heights[row][col];
        if (currentHeight < previousHeight) return;

        string key = string.Concat(row, "-", col);
        if (visited.Contains(key)) return;

        visited.Add(key);

        PacificAtlantic(heights, row + 1, col, currentHeight, visited);
        PacificAtlantic(heights, row - 1, col, currentHeight, visited);
        PacificAtlantic(heights, row, col + 1, currentHeight, visited);
        PacificAtlantic(heights, row, col - 1, currentHeight, visited);

    }
}
