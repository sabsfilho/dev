void Main()
{
	//squares2(3, 9).Dump();
	//squares(35, 70).Dump();
	//squares(17, 24).Dump();
	//squares2(37, 70).Dump();
	squares(100, 1000).Dump();
	//squares2(17, 24).Dump();
}

	public static int squares(int a, int b)
    {
        int q = 0;
		int i=Convert.ToInt32(Math.Sqrt(a));
		while(i <= b)
		{
			int v = i * i;
			if (v >= a && v <= b) q++;
			else if (v > b) break;
			i++;
		}
        return q;
    }
