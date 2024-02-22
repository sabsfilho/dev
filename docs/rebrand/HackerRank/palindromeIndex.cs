void Main()
{
	"aaab,baa,aaa".Split(',').ToList().ForEach(x=>
	palindromeIndex(x).Dump()
	);
	palindromeIndex("quyjjdcgsvvsgcdjjyq").Dump();
}
public static int palindromeIndex(string s)
{
    //if (s == Reverse(s)) return -1;
    int left = 0;
    int right = s.Length - 1;
    while (left < right) {
        if (s[left] != s[right]) {
            break;
        } else {
            left ++;
            right--;
        }
    }
    if (Check(s, left)) {
        return left;
    } else {
        return right;
    }
}
private static string Reverse(string s)
{
	string r = string.Empty;
	for(int i=0;i<s.Length;i++)
	{
		r = string.Concat(s[i],r);
	}
	return r;
}
private static bool Check(string s, int i)
{
    int l = 0;
    int r = s.Length - 1;
    while (l < r) 
	{
        if (l == i) {
            l++;
            continue;
        }
        if (r == i) {
            r--;
            continue;
        }
        if (s[l] != s[r]) 
		{
            return false;
        }
		else
		{
            l++;
            r--;
        }
    }
    return true;
}


    public static int palindromeIndex2(string s)
    {
		var pdic = new Dictionary<char,int>(); //first pos
		var qdic = new Dictionary<char,int>(); //qtd
		for(int i=0; i < s.Length; i++)
		{
			char c = s[i];
			int q;
			if (!qdic.TryGetValue(c, out q))
			{
				qdic.Add(c, 1);
				pdic.Add(c, i);
			}
			else
			{
				if (q == 1)
				{
					if (i - pdic[c] != 1)
					{
						qdic.Remove(c);
						pdic.Remove(c);
						continue;
					}
				}
				qdic[c] = q + 1;
			}
		}
		int max = 0;
		char maxc = '+';
		foreach(var x in qdic)
		{
			int y = x.Value;
			
			if (y > 1 && max > 1)
			{
				return -1;
			}
			
			if (y > max)
			{
				max = y;
				maxc = x.Key;
			}
		}
		if (max > 0)
		{
			foreach(var x in pdic)
			{
				if (x.Key != maxc)
				{
					return x.Value;
				}
			}
		}
		return -1;
    }
