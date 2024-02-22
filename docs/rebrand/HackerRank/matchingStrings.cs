void Main()
{
	var xs = @"aba baba aba xzxb".Split(' ').ToList();
	var qs = @"aba xzxb ab".Split(' ').ToList();
	matchingStrings(xs,qs).Dump();
}
public static List<int> matchingStrings(List<string> strings, List<string> queries)
{
	var xs = new List<int>();
	
	for(int i=0,l=queries.Count;i<l;i++)
	{
		var q = queries[i];
		if (xs.Count < l)
		{
			xs.Add(0);
		}
		int z = xs[i];
		foreach(var w in strings)
		{
			if (q == w)
			{
				z++;
			}
		}
		xs[i] = z;
	}
	
	return xs;
}
