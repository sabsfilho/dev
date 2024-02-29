void Main()
{
	RemoveVowels("ice cream").Dump();
}


public static string RemoveVowels(string str) {

	string r = string.Empty;
	
	var xs = new char[] {
		'a', 'e', 'i', 'o', 'u'
	};
	
	foreach(var c in str) {
		if (!xs.Contains(c)){
			r = string.Concat(r, c);
		}
	}
	
	return r;

}