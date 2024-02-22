void Main()
{
	var x = @"1 2 3 4 5";

	var xs = x.Split('\n').Select(y=>y.Trim().Split(' ').Select(z=>int.Parse(z)).ToList()).ToList();
	var t = dynamicArray(4, xs[0]);
	t.Dump();

}
public static List<int> dynamicArray(int d, List<int> arr)
{	
	int l = arr.Count;
	var rs = new List<int>(l);
	int y = d;
	for (int j = 0; j < l; j++)
	{		
		rs.Add(arr[y]);
		y++;
		if (y >= l)
		{
			y = 0;
		}
	}
	return rs;
}
