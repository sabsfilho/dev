void Main()
{
	
	var arr = new int[] { -4, -1, 0, 3, 10 };
	var r = SortedSquares(arr);
	r.Dump();
}

static int[] SortedSquares(int[] arr){
	int n = arr.Length;
	int i = 0;
	int j = n-1;
	var r = new int[n];
	
	for(int k = n-1; k >=0; k--){
		if (Math.Abs(arr[i]) > Math.Abs(arr[j])) {
			r[k] = arr[i] * arr[i];
			i++;
		}
		else {
			r[k] = arr[j] * arr[j];
			j--;
		}
	}
	return r;
}