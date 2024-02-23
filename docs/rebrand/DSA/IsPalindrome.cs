void Main()
{
	var xs = new string[]{ "madam", "that", "maam" };
	
	foreach(var x in xs){
		Console.WriteLine(string.Concat(x, " IsPalindrome=", IsPalindrome(x)));
	}
}

public static bool IsPalindrome(string x){

	if (string.IsNullOrEmpty(x)) return false;
	
	int i = 0;
	int j = x.Length - 1;
	
	while(i < j) {
		if (x[i] != x[j]){
			return false;
		}
		i++;
		j--;
	}	

	return true;
}
