public class Solution {
    public double FindMaxAverage(int[] nums, int k) {
        if (k == 1) return nums.Max();

        int sum = nums.Take(k).Sum();        
        double mx = Math.Round((double)sum / k, 5);
        //Console.WriteLine($"sum={sum} mx={mx}");
        for(int i=k; i < nums.Length; i++){            
            sum+=(nums[i]-nums[i-k]);
            double avg = Math.Round((double)sum / k, 5);
            //Console.WriteLine($"i={i} sum={sum} mx={mx} avg={avg} a={nums[i-k]} b={nums[i]}");
            if (avg > mx) mx = avg;
        }
        return mx;        
    }
}