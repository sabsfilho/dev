void Main()
{
var ws = @"dkhc=hcdk
fedcbabcd=fedcbabdc
ab=ba
acdb=acbd".Split('\n');
 foreach(var x in ws)
 {
	var xs = x.Split('=');
	var w = xs[0].Trim();
	var r = biggerIsGreater(w);
	string.Concat(w,">",r,r==xs[1].Trim()?"=":"<>",xs[1]).Dump();
	//break;
}
}

    public static string biggerIsGreater(string w)
    {
        var xs = w.ToCharArray();
        int l = xs.Length - 1;
        int i = l;
        while(i > 0 && xs[i-1] >= xs[i]) //pivot char
        {
            i--;
        }
		if (i > 0)
		{
			i--;
			int j = l;
			while(j >= 0 && xs[j] <= xs[i]) //next char
			{
				j--;
			}			
			char v = xs[j];
			xs[j] = xs[i];
			xs[i] = v; //swap
			int d = l - i;
			if (d > 1) //reverse next chars
			{
				Array.Reverse(xs, i+1, l - i);
			}
	        return new string(xs);
        }
		return "no answer";
    }
