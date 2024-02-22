void Main()
{
	BuildSlider("dkhc").Dump();
}

static string[] BuildSlider(string w)
{
	var len = w.Length;
	var xs = new string[16];
	int q = 0;	
	for (int j = 0; j < len; j++)
	{
		if (j > 0)
		{
			w = Swap(w, j, 0);
		}
		for(int i = 0; i < len; i++)
		{
			//string.Concat(++q,"=",i,"=",j,":",Swap(w, 0, i)).Dump();
			xs[q++] = Swap(w, 0, i);
		}
	}
	return xs;
}

static string Swap(string w, int i, int j)
{
	var ws = w.ToCharArray();
	
	var t = ws[i];
	ws[i] = ws[j];
	ws[j] = t;
	
	return new string(ws);
}
