void Main()
{
	int[] xs = new int[6]{ 5, 9, 13, 15, 1, 2 };
	
	int min = FindMinimum(xs);
	
	Console.WriteLine(min);
}

public static int FindMinimum(int[] xs){
	
	if (xs == null || xs.Length == 0){
		throw new ArgumentException("Invalid array input");
	}
	
	int min = xs[0];
	
	for(int i=1; i < xs.Length; i++){
		if (xs[i] < min){
			min = xs[i];
		}
	}
	
	return min;
}