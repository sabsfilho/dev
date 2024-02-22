void Main()
{
	var a = new int[]{2, 3, 4, 6, 12};
	CountTriplets(a).Dump();
}

int CountTriplets(int[] a)
{
//i < j < k and A[i] * A[j] = A[k]
	int q = 0;
	
	var d = new Dictionary<int,int>();
	
	for(int j=a.Length-2;j>=1;j--)
	{
		int z = a[j+1];
		if (d.ContainsKey(z)){
			d[z]++;
		}
		else{
			d[z]=1;
		}
		for(int i=0;i<j;i++)
		{
			int w;
			if (d.TryGetValue(a[i]*a[j], out w)){
				q += w;
			}			
		}
	}
	return q;
}

