void Main()
{
	var xs = "ebacd,fghij,olmkn,trpqs,xywuv".Split(',').ToList();	
	
	gridChallenge(xs).Dump();
}

    public static string gridChallenge(List<string> grid)
    {
		char[] ys = null;
		foreach(var s in grid)
		{
			var xs = s.ToCharArray().OrderBy(x=>x).ToArray();
			if (ys == null)
			{
				ys = xs;				
			}
			else
			{
				for(int i = 0; i < xs.Length; i++)
				{
					if (xs[i] < ys[i])
					{
						return "NO";
					}
				}
			}
		}
		return "YES";
    }
