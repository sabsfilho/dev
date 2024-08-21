public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        var d = new Dictionary<int,int>();
        foreach(int a in arr){
            if (d.ContainsKey(a)){
                d[a]++;
            }
            else {
                d.Add(a, 1);
            }
        }
		return 
			(new HashSet<int>(d.Values)).Count == d.Values.Count;
        /*
		return
            d
            .GroupBy(x=>x.Value)
			.Select(x=>x.Count())
            .Where(x=>x>1)
			.Count() == 0;
        */
    }
}