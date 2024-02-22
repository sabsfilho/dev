void Main()
{
/*
dbac
3
c
nvzjkcahjwlhmdiuobjdwbanmvrtadopapbktdtezellktgywrdstdhhayaadqrdhspavjgxprk
2071
b
szkkcedhlkhjnjofbrnvhntsushncjavkmfn
465
d
wcweojncpqwcofrhxnzgbdrd
251
d
pfpgrnlorzzhdoxzsnemubzvkcbbfb
77
o
judaioobpoiteiszvzlscmpmpqqwuvtdqzdapudfimaowsnttalwndievaapwusmtyoksrpcfpqbkgvfiibvlkbjkcy
2473
w

b
d
d
o
w
*/
	ashtonString("dbac", 3).Dump();
	//ashtonString("nvzjkcahjwlhmdiuobjdwbanmvrtadopapbktdtezellktgywrdstdhhayaadqrdhspavjgxprk", 2071).Dump();
	
}
public static char ashtonString(string s, int k)
{
	var xs = s.ToCharArray().Distinct().OrderBy(x=>x).ToArray();
	
	string r = string.Empty;
	
	int l = xs.Length;
		
	for(int i = 0; i < l; i++)
	{
		var a = xs[i].ToString();
		a.Dump();
		
		r = string.Concat(r, a);
		
		var y = s.IndexOf(a);
		
		for(int j = y, jl = s.Length; j < jl; j++)
		{
			int len = jl - j;
			var b = s.Substring(y, len);
			string.Concat(j,"-",s.Length, "+", len,"-", y, "=", b).Dump();
			if (a != b)
			{
				r = string.Concat(r, b);
			}
		}
		
	}

	return r[k - 1];
}
