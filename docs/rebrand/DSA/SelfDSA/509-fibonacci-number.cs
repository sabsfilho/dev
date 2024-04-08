public class Solution {
    public int Fib(int n) {
        if (n == 0) return 0;
        int c = 1;
        int b = 1;
        int a = 1;
        for(int i = 2; i < n; i++){
            a = b + c;
            c = b;
            b = a;
        }
        return a;        
    }
}