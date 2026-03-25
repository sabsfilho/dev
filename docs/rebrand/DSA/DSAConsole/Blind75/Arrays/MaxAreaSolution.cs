public class MaxAreaSolution {
    public int MaxArea(int[] heights) {
        /*
        max = H * W
        */
        int max = 0;
        int a = 0;
        int W = heights.Length - 1;
        int L = 0;
        int R = W;

        while(L < R)
        {
            if (L == heights.Length || R < 0) break;
            int HL = heights[L];
            int HR = heights[R];
            int H = Math.Min(HL, HR);
            a = W * H;
            if (a > max) max = a;
            if (HL > HR)
            {
                R--;
            }
            else 
            {
                L++;
            }
            W--;
        }
        if (a > max) max = a;

        return max;        
    }
}
