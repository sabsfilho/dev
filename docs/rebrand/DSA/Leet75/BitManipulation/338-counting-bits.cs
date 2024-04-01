public class Solution {
    public int[] CountBits(int n) {
        var xs = new int[n+1];
        int z = 1;
        for(int i = 1; i <= n; i++){
            if (z * 2 == i){
                z = i;
            }
            xs[i] = 1 + xs[i - z];

        }
        return xs;
    }
}