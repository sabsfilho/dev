void Main()
{
	var xs = new List<int>{1, 4, 5, 7, 9, 12};
	int v = 4;
	//1
	introTutorial(v, xs).Dump();
}

// Define other methods and classes here

    public static int introTutorial(int V, List<int> arr)
    {
		return arr.IndexOf(V);
    }
