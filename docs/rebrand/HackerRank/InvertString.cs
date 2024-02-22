void Main()
{
	Invert("dkhc").Dump();
	Invert("samuel").Dump();
}


static string Invert(string w)
{
	var ws = w.ToCharArray();
	int len = w.Length;
	var xs = new char[len];
	
	for(int i = 0; i < len; i++)
	{
		xs[i] = ws[len - i - 1];
		
	}
	
	return new string(xs);
}
