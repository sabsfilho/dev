void Main()
{
	int[] xs = new int[6]{ 12,34,2,34,33,1 };
	
	int maxLinq = FindSecondMaximumLinq(xs);
	int max = FindSecondMaximum(xs); //wiser
	
	Console.WriteLine(maxLinq);
	Console.WriteLine(max);
}

public static int FindSecondMaximumLinq(int[] xs){
	/* LANGUAGE INTEGRATED QUERY SOLUTION */
	if (xs == null || xs.Length < 2){
		throw new ArgumentException("Invalid array input");
	}
	
	return 
		xs
		.Distinct()
		.OrderByDescending(x=>x)
		.Skip(1)
		.Take(1)
		.FirstOrDefault();
}

public static int FindSecondMaximum(int[] xs){
	/* LANGUAGE INTEGRATED QUERY SOLUTION */
	if (xs == null || xs.Length < 2){
		throw new ArgumentException("Invalid array input");
	}
	int max1 = int.MinValue;
	int max2 = int.MinValue;
	
	for(int i = 0; i < xs.Length; i++){
		int x = xs[i];
		if (x > max1) {
			max2 = max1;
			max1 = x;
		}
		else if (
			x > max2 && 
			x != max1
		){
			max2 = x;
		}
	}
	
	return max2;
}

