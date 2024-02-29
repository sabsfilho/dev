void Main()
{
	FirstNonRepeatingCharacter("codeforcode").Dump(); // 4
	FirstNonRepeatingCharacter("aabb").Dump(); // -1
	
	FirstNonRepeatingCharacter("racecars").Dump(); // 3
	FirstNonRepeatingCharacter("aabb").Dump(); // -1
}

public static int FirstNonRepeatingCharacter(string str) {

	var d = new Dictionary<char, int>();
	
	foreach(var c in str){
		int x = 0;
		d.TryGetValue(c, out x);
		d[c] = x + 1;
	}
	
	for(int i=0; i < str.Length; i++) {
		if (d[str[i]] == 1) {
			return i;
		}
	}
	
	//d.Dump();
	
	return -1;
}