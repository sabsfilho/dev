public class Solution {
    public int HammingWeight(int n) {
        int r = 0;
        while(n>0){
            int m = n % 2;
            if (m == 1) r++;
            n = n / 2;
        }
        return r;
    }
}