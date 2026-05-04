public class ClimbStairsSolution {
    /* Climbing Stairs
x(3)=x(2) + x(1)=2+1
x(2)=x(1) + x(0) = 1 + 1=2
x(1)=1
    */
    public int ClimbStairs(int n) {   
        if (n <= 1) return 1;
        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}