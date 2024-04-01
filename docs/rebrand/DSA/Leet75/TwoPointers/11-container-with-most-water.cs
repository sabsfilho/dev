public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;

        int l = 0;
        int r = height.Length - 1;

        while(l < r) {
            int W = r - l;
            int L = height[l];
            int R = height[r];
            int H = L < R ? L : R;
            int V = W * H;
            if (V > max) max = V;
            if (R > L) l++;
            else r--;
        }

        return max;
    }
}