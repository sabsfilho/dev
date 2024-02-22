void Main()
{
	//countInversions(new List<int>(){2, 1, 3, 1, 2}).Dump();
	countInversions(new List<int>(){2, 1, 3, 1, 2}).Dump();
}

static long merge(List<int> arr, int l, int m, int r)
{
	long q = 0;
	
	int n1 = m - l + 1;
	int n2 = r - m;
	
	var L = arr.Skip(l).Take(n1).ToArray();
	var R = arr.Skip(m+1).Take(n2).ToArray();
	
    int i = 0;
    int j = 0;
    int k = l;
	
    while (i < n1 && j < n2) {
        if (L[i] <= R[j]) {
		string.Concat(arr[k] , "+L", L[i]).Dump();
			arr[k] = L[i];
            i++;
        }
        else {
		q++;
		string.Concat(arr[k] , "+R", R[j]).Dump();
			arr[k] = R[j];
            j++;
        }
        k++;
    }

    while (i < n1) {
		string.Concat(arr[k] , "+L", L[i]).Dump();
		arr[k] = L[i];
        i++;
        k++;
    }

    while (j < n2) {
		string.Concat(arr[k] , "+R", R[j]).Dump();
		arr[k] = R[j];
        j++;
        k++;
    }
	
	return q;
}

static long sort(List<int> arr, int l, int r)
{
	long q = 0;
	
	if (l < r)
	{
		int m = l + (r - l)/2;
		q += sort(arr, l, m);
		q += sort(arr, m+1, r);
		q += merge(arr, l, m, r);
	}
	return q;
}

static long countInversions(List<int> arr)
{
	long q = sort(arr, 0, arr.Count-1);
	arr.Dump();
	return q;
}
