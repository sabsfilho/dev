void Main()
{
var x = @"4 5 8
2 4 1
1 9 7";
/*x = @"3 5 7
9 5 1
3 5 7";*/
var s = x.Split('\n').Select(y=>y.Split(' ').Select(u=>int.Parse(u)).ToList()).ToList();
//formingMagicSquare(s).Dump();

IsMagicSquare(s).Dump();
s.Dump();
}

static bool IsMagicSquare(List<List<int>> s)
{
	int n = s.Count;
	int k = n * (n*n + 1) / 2;
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
		dg1s == k &&
		dg2s == k &&
		cols.All(x=>x==k) &&
		rows.All(x=>x==k)
	)
	{
		return true;
	}
	return false;
}
