void Main()
{
	BuildPermutations("dkhc").Dump();
	//BuildPermutations("khc").Dump();
}

static List<string> BuildPermutations(string w)
{
	var ws = w.ToCharArray();
	var rs = BuildPermutation(ws, ws.Length);
	return rs;
}

static List<string> BuildPermutation(char[] ws, int len)
{
	var rs = new List<string>();
	
	if (len == 1)
	{
		rs.Add(new string(ws));
	}
	else
	{	
		int lasti = len - 1;
		for(int i = 0; i < len; i++)
		{			
			var ys = BuildPermutation(ws, lasti);			
			rs.AddRange(ys);
				
			if (len % 2 == 0)
			{
				//CurrentAndLast
				Swap(ws, i, lasti);
			}
			else
			{
				//FirstAndLast
				Swap(ws, 0, lasti);
			}
		}
	}
	return rs;
}


static void Swap(char[] ws, int i, int j)
{	
	var t = ws[i];
	ws[i] = ws[j];
	ws[j] = t;
}
