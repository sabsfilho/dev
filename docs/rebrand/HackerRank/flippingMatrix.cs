void Main()
{
	//flipping the matrix
	var qs = Build();
	flippingMatrix(qs).Dump();
	/*
	reverseCol(qs, 2);
	reverseRow(qs, 0);
	calc(qs, 0).Dump();*/
	/*
	qs[0].Dump();
	reverseRow(qs, 0);
	*/
	//qs.Dump();
	
	
	//414
}

public static int flippingMatrix(List<List<int>> m)
{
	int n = m.Count / 2;
	int max = 0;
	int total = 0;

    for(int row = 0; row < n; row++) {
	    for(int col = 0; col < n; col++) {
	        max = 0;
	        max = Math.Max(m[row][col], max);
	        max = Math.Max(m[row][n*2 - 1 - col], max);
	        max = Math.Max(m[n*2 - 1 - row][col], max);
	        max = Math.Max(m[n*2 - 1 - row][n*2 - 1 - col], max);

	        total += max;
	    }
	} 
	return total;
}


    public static int flippingMatrix2(List<List<int>> matrix)
    {
		return reverseAndCalc(matrix, int.MinValue);
	}
	static int reverseAndCalc(List<List<int>> m, int max)
	{
		int l = m.Count;
		max = calc(m, max);
		for(int i=0;i<l;i++)
		{
			for(int j=0,jl=m[i].Count;j<jl;j++){
			
	reverseCol(m, i);
		max = calc(m, max);
	reverseRow(m, j);
		max = calc(m, max);
				string.Concat("col:",i,",row:",j,",max:",max).Dump();
			}			
		}
		/*int l = m.Count;
		max = calc(m, max);
		for(int i=0;i<l;i++){
			reverseCol(m, i);
			max = calc(m, max);
			for(int j=0,jl=m[i].Count;j<jl;j++){
				reverseRow(m, j);
				max = calc(m, max);
			}
		}*/
		return max;
	}
	static int calc(List<List<int>> m, int max)
	{
		int q = 0;
		for(int i=0;i<2;i++){
			for(int j=0;j<2;j++){
				q += m[i][j];
			}
		}
		return (q > max) ? q : max;
	}
	static void reverseRow(List<List<int>> m, int row)
	{	
		m[row].Reverse();	
	}
	static void reverseCol(List<List<int>> m, int col)
	{	
		int l = m.Count;
		var xs = new int[l]; 
		for(int i = 0; i < l; i++)
		{
			xs[i] = m[l - i - 1][col];
		}
		for(int i = 0; i < l; i++)
		{
			m[i][col] = xs[i];
		}
	}
	static List<List<int>> Build()
{
/*
112 42 83 119
56 125 56 49
15 78 101 43
62 98 114 108
414

107 54 128 15
12 75 110 138
100 96 34 85
75 15 28 112
488
*/

        List<List<int>> queries = new List<List<int>>();
var x = @"112 42 83 119
56 125 56 49
15 78 101 43
62 98 114 108".Split('\n');

        for (int i = 0; i < x.Length; i++)
        {
            queries.Add(x[i].Trim().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }
		return queries;
}
