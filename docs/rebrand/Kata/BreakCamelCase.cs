  public static string BreakCamelCase(string str)
  {
  	if (
		str == null || 
		str.Length < 2
	) {
		return str;
	}
  
    string x = str.Substring(0,1);
	
	for(int i=1; i < str.Length; i++){
		char c = str[i];
		if (c >= 'A' && c <= 'Z') {
			x = string.Concat(x, ' ');
		}
		x = string.Concat(x, c);
	}
	
	return x;
  }