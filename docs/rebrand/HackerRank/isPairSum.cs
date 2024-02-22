void Main()
{

        int[] arr = { 2, 3, 5, 8, 9, 10, 11 };
 
        int val = 17;
 
        Console.Write(isPairSum(arr, arr.Length, val));
}

private static bool isPairSum(int[] A, int N, int X)
{
	Array.Sort(A);
	
	int i = 0;
	int j = N-1;
	while(i < j)
	{
		int v = A[i]+A[j];
"{0}[{1}] + {2}[{3}] = {4}".set(A[i],i,A[j],j,v).Dump();
		if (v==X) return true;
		if (v < X) i++;
		else j--;
	}

	return false;
}
