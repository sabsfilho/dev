void Main()
{
	IsSubSequence("abcdef", "ace").Dump();
}

public static bool IsSubSequence(string str, string seq) {

	int i = 0;
	int j = 0;
	
	while(i < str.Length && j < seq.Length) {
		if (str[i] == seq[j]) {
			j++;
		}
		i++;
	}
	
	return j == seq.Length;
}