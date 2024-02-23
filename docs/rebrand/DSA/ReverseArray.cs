void Main()
{
	int[] xs = new int[6]{ 2, 11, 5, 10, 7, 8 };
	
	ReverseArray(xs, 0, xs.Length-1);
	
	Console.WriteLine(string.Join(",", xs));
}

public static int[] ReverseArray(int[] xs, int start, int end){
	while(start < end){
		int t = xs[start];
		xs[start] = xs[end];
		xs[end] = t;
		start++;
		end--;
	}
	return xs;
}

