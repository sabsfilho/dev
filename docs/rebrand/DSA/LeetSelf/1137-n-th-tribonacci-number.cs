public class Solution {
    public int Tribonacci(int n) {
        if (n == 0) return 0;
        if (n == 1) return 1;
        if (n == 2) return 1;
        int x0 = 0;
        int x1 = 1;
        int x2 = 1;
        for(int i = 3; i <= n; i++){

            int x3 = x2 + x1 + x0;
            x0 = x1;
            x1 = x2;
            x2 = x3;

        }
        return x2;
    }
}