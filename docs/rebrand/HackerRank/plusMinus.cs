void Main()
{
	plusMinus(new List<int>(){-4, 3, -9, 0, 4, 1});
}

// Define other methods and classes here
    public static void plusMinus(List<int> arr)
    {
		int p = 0;
		int n = 0;
		int e = 0;
		int q = arr.Count;
		foreach(var a in arr){
			if (a > 0) p++;
			else if (a < 0) n++;
			else e++;
		}
		
		Console.WriteLine((decimal)p/q);
		Console.WriteLine((decimal)n/q);
		Console.WriteLine((decimal)e/q);

    }
