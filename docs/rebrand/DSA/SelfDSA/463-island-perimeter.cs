public class Solution {
    public int IslandPerimeter(int[][] grid) {
        int rows = grid.Length;
        if (rows == 0) return 0;
        int cols = grid[0].Length;
        if (cols == 0) return 0;
        int sum = 0;
        for(int i = 0; i < rows; i++) {
            int q = 0;
            int p = 0;
            for (int j = 0; j < cols; j++) {
                int n = grid[i][j];
                if (n == 1) {
                    q++;
                    //top
                    if (i == 0) p++;
                    else if (grid[i-1][j] == 0) p++;
                    //left
                    if (j == 0) p++;
                    else if (grid[i][j-1] == 0) p++;
                    //right
                    if (j == cols-1) p++;
                    else if (grid[i][j+1] == 0) p++;
                    //bottom
                    if (i == rows-1) p++;
                    else if (grid[i+1][j] == 0) p++;
                }
                //Console.Write(n+" ");
            }
            sum += p;
            //Console.WriteLine("; q="+q+";p="+p+";sum="+sum);
        }
        //Console.WriteLine(rows+":"+cols);

        return sum;
    }
}