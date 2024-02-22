void Main()
{
var a = new List<int>(){4,6,5,3,3,1};
var x = @"4 97 5 97 97 4 97 4 97 97 97 97 4 4 5 5 97 5 97 99 4 97 5 97 97 97 5 5 97 4 5 97 97 5 97 4 97 5 4 4 97 5 5 5 4 97 97 4 97 5 4 4 97 97 97 5 5 97 4 97 97 5 4 97 97 4 97 97 97 5 4 4 97 4 4 97 5 97 97 97 97 4 97 5 97 5 4 97 4 5 97 97 5 97 5 97 5 97 97 97";
a = x.Split(' ').Select(y=>int.Parse(y)).ToList();

	pickingNumbers(a).Dump();
}

// Define other methods and classes here

    
    public static int pickingNumbers(List<int> a)
    {
        var d = new Dictionary<int, int>(); // [n,q]
        
        foreach(int n in a)
        {
            int q;
            if (d.TryGetValue(n, out q))
            {
                d[n] = q + 1;
            }
            else {
                d[n] = 1;
            }
        }		
		int mx = 0;
		foreach(var x in d)
		{
			int xk = x.Key;
			int xv = x.Value;
			int q = 0;
			foreach(var y in d)
			{
				int yk = y.Key;
				if (
					xk != yk &&
					Math.Abs(xk - yk) < 2
				) 
				{
					q = xv + y.Value;
				}
			}
			if (xv > q)
			{
				q = xv;
			}
			if (q > mx)
			{
				mx = q;
			}
		}
        
        return mx;

    }
