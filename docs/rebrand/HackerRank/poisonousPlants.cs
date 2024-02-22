void Main()
{
var ps = new List<int>(){ 6,5,8,4,7,10,9 };
poisonousPlants(ps).Dump();
}

// Define other methods and classes here
public static int poisonousPlants(List<int> p)
{
	var lifo = new Stack<int[]>();
	int d = 0;
	foreach(int x in p)
	{
		int day = 0;
		while(lifo.Count > 0)
		{
			var z = lifo.Peek();
			if (z[0] >= x)
			{
				lifo.Pop();
				if (z[1] > day) day = z[1];
			}
			else break;
		}
		if (lifo.Count > 0) day++;
		else day = 0;
		if (day > d) d = day;
		lifo.Push(new int[]{x, day});
	}
    return d;

}
