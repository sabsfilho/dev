void Main()
{

	timeConversion("10:01:00AM").Dump();	
}

// Define other methods and classes here

    public static string timeConversion(string s)
    {
		int l = s.Length;
		
		if (l < 10){
			s = string.Concat("0", s);
		}
		
		string r = s;
		int i = s.Length-2;
		var pfx = s.Substring(0, 2);
		var sfx = s.Substring(i);
		var s2 = s.Substring(2, i - 2);
		if (sfx == "PM")
		{
			int u = int.Parse(pfx);
			if (u != 12)
			{
				u+=12;
			}
			r = string.Concat(u, s2);
		}
		else
		{
			if (pfx == "12" || pfx == "00")
			{
				r = string.Concat("00", s2);
			}
			else
			{
				r = s.Substring(0, i);
			}
		}		
		
		return r;

    }
