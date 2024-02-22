void Main()
{
	var ws = new List<string>()
	{
@"hackerhappy
hackerrank
9
Yes",
@"ashley
ash
2
No",
@"uoiauwrebgiwrhgiuawheirhwebvjforidkslweufgrhvjqasw
vgftrheydkoslwezxcvdsqjkfhrydjwvogfheksockelsnbkeq
100
Yes",
@"abcd
abcdert
10
No",
@"asdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv
bsdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcvasdfqwertyuighjkzxcv
100
No",
@"zzzzz
zzzzzzz
4
Yes"
	};
	foreach(var w in ws)
	{
		var xs = w.Split('\n');
		var r = appendAndDelete(xs[0].Trim(), xs[1].Trim(), int.Parse(xs[2]));
		if (r != xs[3]) string.Concat(xs[0], "=", xs[3], "<>", r).Dump();
	}
}

public static string appendAndDelete(string s, string t, int k)
{        
	if (s == t)
	{
		return "Yes";
	}
	int sl = s.Length;
	int tl = t.Length;
    if (sl == tl)
    {
        return  sl < k ? "Yes" : "No";
    }
    int d = 0;
    if (sl > tl)
    {
		if (sl - tl > k) return "No";
		
        d = Delete(s, t);
        if (d > 0)
        {
            s = s.Substring(0, s.Length - d);
        }
    }
	else
	{
		if (tl - sl < k)
		{
			if (string.Concat(s, t.Substring(0, tl - sl)) == t) return "Yes";
		}
	
		return "No";
	}
    int a = t.Length - s.Length;
    if (a >= 0 && s == t.Substring(0, s.Length))
    {
        if (d + a <= k && (d > a || a > 0))
        {
            return "Yes";
        }
    }
    return "No";

}

static int Delete(string s, string t)
{
    if (s == t || s.Length == 0) return 0;
    
    if (s.Length > t.Length){
        return 1 + Delete(s.Substring(0,s.Length-1), t);
    }
    return 1 + Delete(s.Substring(0,s.Length-1),t.Substring(0,t.Length-1));
}
