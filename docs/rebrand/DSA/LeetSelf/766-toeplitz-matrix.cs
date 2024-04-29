public class Solution {
    public bool IsToeplitzMatrix(int[][] matrix) {

        for(int i=1;i<matrix.Length;i++){
            for(int j=1;j<matrix[0].Length;j++){

                int x = matrix[i-1][j-1];
                int y = matrix[i][j];
                //Console.WriteLine(x+":"+y);
                if (x != y) return false;
            }
        }
        return true;
        
    }
}