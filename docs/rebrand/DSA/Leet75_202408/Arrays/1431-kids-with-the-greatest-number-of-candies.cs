public class Solution {
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) {
        var lst = new bool[candies.Length];

        for(int i = 0; i < candies.Length; i++){
            var xs = candies.ToList();
            xs.RemoveAt(i);
            int max = xs.Max();            
            lst[i] = candies[i] + extraCandies >= max;
        }

        return lst;
    }
}