void Main()
{
	LengthOfLongestSubstring("pwwkew").Dump();
}

int LengthOfLongestSubstring(string s) {
	var d = new Dictionary<char, int>();
	
	int maxLength = 0;
	int start = 0;
	for(int end = 0; end < s.Length; end++) {
	
		char rightChar = s[end];
		if (d.ContainsKey(rightChar)) {
			start = Math.Max(start, d[rightChar] + 1);
		}
		d[rightChar] = end;
		maxLength = Math.Max(maxLength, end - start + 1);	
	}
	return maxLength;
}