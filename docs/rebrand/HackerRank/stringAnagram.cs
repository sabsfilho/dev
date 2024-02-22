void Main()
{
	
	var d = new List<string>(){ "heater", "cold", "clod", "reheat", "docl" };
	var q = new List<string>(){ "codl", "heater", "abcd" };
	
	//contains("codl", "cold").Dump();
	stringAnagram(d,q).Dump();
	//3,2,0
}

    public static List<int> stringAnagram(List<string> dictionary, List<string> query)
	{
		var xs = new List<int>();
		
		foreach(var q in query)
		{
			int u = 0;
			foreach(var d in dictionary)
			{
				if (contains(q, d))
				{
					u++;
				}
			}
			xs.Add(u);
		}
		
		return xs;		
	}
	
	static string sort(string x)
	{
		return string.Join(string.Empty,x.ToCharArray().OrderBy(y=>y));
	}
	
	static bool contains(string q, string txt)
	{
	    int m = q.Length;
	    string sortedpat = sort(q);
	    for (int i = 0, l = txt.Length - q.Length; i <= l; i++) 
		{
	        var temp = string.Empty;
	        for (int k = i; k < m + i; k++)
			{
				temp = string.Concat(temp, txt[k]);
			}
	        temp = sort(temp);
	        if (sortedpat == temp)
			{
	            return true;
			}
	    }
		return false;
	}
