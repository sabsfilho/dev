void Main()
{
	countApplesAndOranges(7, 11, 5, 15, new List<int>(){-2,2,1}, new List<int>(){5,-6});
}

// Define other methods and classes here
   public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
		apples.Select(x=>x+a).Where(x=>x>=s&&x<=t).Count().Dump();
		oranges.Select(x=>x+b).Where(x=>x>=s&&x<=t).Count().Dump();

    }
