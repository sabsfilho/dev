void Main()
{
	var lns = File.ReadAllLines(@"C:\Users\Owner\Downloads\a.csv");	
	
	var ranked = lns[1].TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();
	var player = lns[3].TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();
	
	var rs = climbingLeaderboard(ranked, player);
	
	File.WriteAllLines(@"C:\Users\Owner\Downloads\b.csv", rs.Select(x=>x.ToString()));	
}

static SortedDictionary<int, SortedList<int,int>> BuildRank(List<int> rs, out int cnt, out int first, out int last)
{
	cnt = 0;
	first = int.MaxValue;
	last = 0;
	var d = new SortedDictionary<int, SortedList<int,int>>();
	
	foreach(var r in rs)
	{
		var k = GetKey(r);
		SortedList<int, int> rnks;
		if (!d.TryGetValue(k, out rnks))
		{
			rnks = new SortedList<int,int>();
			d.Add(k, rnks);
		}
        if (!rnks.ContainsKey(r))
        {
			cnt++;
			if (r < first)
			{
				first = r;
			}
			if (r > last)
			{
				last = r;
			}
            rnks.Add(r, cnt);
        }
	}
	
	return d;
}

static int GetKey(int p)
{
	return p - (p % 1000);
}

public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
{
    int cnt, first, last;
	var rankDic = BuildRank(ranked, out cnt, out first, out last); //paged rank
    
    var d = new Dictionary<int, int>();
    
    var rs = new List<int>();
    foreach(var p in player)
    {
        int m;
		if (p < first)
		{
			m = cnt + 1;
		}
        else if (p >= last)
        {
            m = 1;
        }
        else if (!d.TryGetValue(p, out m)) // cached
        {
			int k = GetKey(p);
			
			SortedList<int,int> rnks;
			if (!rankDic.TryGetValue(k, out rnks) || p > rnks.LastOrDefault().Key)
			{			
				foreach(var w in rankDic)
				{
	                if (k < w.Key)
	                {
	                    rnks = w.Value;
	                    break;
	                }
				}
			}
			
            foreach(var w in rnks)
            {
				int r = w.Key;
				int n = w.Value;
                if (p < r)
                {
                    m = n + 1;
                    break;
                }
                else if (p == r)
                {
                    m = n;
                    break;
                }
            }
            d.Add(p, m); // cache
			
			// remove visited
			var rems = new List<int>();
			foreach(var w in rankDic)
			{
                if (w.Key < k)
                {
					rems.Add(w.Key);
                }
				else
				{
					break;
				}
			}
			foreach(var r in rems)
			{
				rankDic.Remove(r);
			}
        }
        rs.Add(m);
    }
            
    return rs;
}
