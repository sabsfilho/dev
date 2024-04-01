public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var d = new Dictionary<int, int>(); //n,q
        foreach(int n in nums){
            if (d.ContainsKey(n)){
                d[n]++;
            }
            else {
                d[n] = 1;
            }
        }
        return
            d
            .OrderByDescending(x=>x.Value)
            .Take(k)
            .Select(x=>x.Key)
            .ToArray();
    }
}