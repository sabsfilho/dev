void Main()
{
var s = @"4 5 8
2 4 1
1 9 7".Split('\n').Select(y=>y.Split(' ').Select(u=>int.Parse(u)).ToList()).ToList();
//formingMagicSquare(s).Dump();

formingMagicSquare(s).Dump();
s.Dump();
}
static int formingMagicSquare(List<List<int>> s)
{
	int n = s.Count;
	int k = 5 * n;
	var cols = new int[n];
	var rows = new int[n];
	int dg1s = 0;
	int dg2s = 0;
	int r = 0;
	int c = 0;
	foreach(var cs in s)
	{
		c = 0;
		foreach(var v in cs)
		{
			cols[c] += v;
			rows[r] += v;
			if (c==r)
			{
				dg1s += v;
			}
			if (n-r-1==c)
			{
				dg2s += v;
			}
			c++;
		}
		r++;
	}
	if (
		cols.All(x=>x==k) &&
		rows.All(x=>x==k) &&
		dg1s == k &&
		dg2s == k
	)
	{
		return 0;
	}
	/*
	cols.Dump();
	rows.Dump();
	dg1s.Dump();
	dg2s.Dump();
	*/
	r = 0;
	foreach(var xr in rows)
	{
		int dr = xr - k;
		if (dr != 0)
		{
			c = 0;
			foreach(var xc in cols)
			{
				int dc = xc - k;
				if (dc != 0)
				{
					var v = s[r][c];
					if (dr > 0 && v > 1)
					{
						s[r][c]--;
						return 1 + formingMagicSquare(s);
					}
					else if (dr < 0 && v < 9)
					{
						s[r][c]++;
						return 1 + formingMagicSquare(s);
					}
				}
				c++;
			}
		}
		r++;
	}
	r = 0;
	foreach(var xr in rows)
	{
		c = 0;
		foreach(var xc in cols)
		{
			int dc = xc - k;
			if (dc != 0)
			{	
				if (
					(dg1s == k && r == c) ||
					(dg2s == k && c == (n - r - 1))
				)
				{
					continue;
				}
				var v = s[r][c];
				if (v < 9)
				{
					s[r][c]++;
					for(int i=1;i<n;i++)
					{
						if (cols[c+i]!=k){
							s[r][c+i]--;
							break;
						}
					}
					return 1 + formingMagicSquare(s);
				}
			}
			c++;
		}
		r++;
	}	
	return 0;
}
