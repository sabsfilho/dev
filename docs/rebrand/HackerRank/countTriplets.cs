void Main()
{
countTriplets(new List<long>{1,3,9,9,27,81},3).Dump();//6
countTriplets(new List<long>{1,5,5,25,125},5).Dump();//4
countTriplets(new List<long>{1,2,2,4},2).Dump();//2
countTriplets(new List<long>{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},1).Dump();//161700

}

    static long countTriplets(List<long> arr, long r) {
		long q = 0;
		
		var cs = new Dictionary<long,long>();
		var ps = new Dictionary<long,long>();
		foreach(long a in arr)
		{
			q += Get(cs,a);
			long b = a * r;
			cs[b] = Get(cs,b) + Get(ps,a);
			if (!ps.ContainsKey(b)) ps[b] = 1;
			else{
				ps[b]++;
			}
		}
	
		return q;
}
static long Get(Dictionary<long,long> xs, long k)
{
	long v = 0;
	return xs.TryGetValue(k, out v) ? v : 0;
}
