    public static string LongestConsec(string[] strarr, int k) 
    {
		if (
			strarr.Length == 0 || 
			k > strarr.Length ||
			k <= 0
		){
			return string.Empty;
		}
	
		int max = 0;
		string x = string.Empty;
		
		for(int i=0, len = strarr.Length - k + 1; i < len; i++){
			string y = string.Join(string.Empty, strarr.Skip(i).Take(k));
			if (y.Length > max){
				max = y.Length;
				x = y;
			}
		}
	
        return x;
    }
