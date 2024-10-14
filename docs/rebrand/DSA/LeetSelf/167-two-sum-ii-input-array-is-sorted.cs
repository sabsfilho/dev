public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int len = numbers.Length - 1;
        int L = 0;
        int R = len;

        while (L < R)
        {
            int nl = numbers[L];
            int nr = numbers[R];
//Console.WriteLine($"{L}:{nl};{R}:{nr};sum={nl+nr}");
            if (nl + nr == target)
                return new int[] { L + 1, R + 1};
            if (L == R-1){
                L++;
                R = len;
            }
            else
                R--;
        }
        return new int[]{};
        
    }
}