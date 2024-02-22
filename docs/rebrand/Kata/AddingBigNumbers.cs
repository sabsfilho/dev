  public static string Add(string a, string b)
  {
  	int len = Math.Max(a.Length, b.Length);
	
	a = a.PadLeft(len, '0');
	b = b.PadLeft(len, '0');
	
	string r = string.Empty;
	
	int n = 0;
	for(int i=len-1; i >= 0; i--)
	{
		int x = int.Parse(a[i].ToString());
		int y = int.Parse(b[i].ToString());
			
		int v = x + y + n;
		
		if (v > 9) {		
			v = v % 10;
			n = 1;			
		}
		else {
			n = 0;
		}
		
		r = string.Concat(v, r);
	}
	if (n > 0) {
		r = string.Concat(n, r);
	}
	return r;  
  }