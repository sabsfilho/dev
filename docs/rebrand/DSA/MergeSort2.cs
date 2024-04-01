void Main()
{
        

	var xs = new int[]{ 1, 2, 13, 24, 25, 36, 37 };
	for(int i = 0; i < 100; i++){
		Shuffle(xs, i);
		string shuffled = string.Join(", ", xs);
		string merged = string.Join(", ", MergeSort(xs));
		var ys = xs.ToArray();
		Array.Sort(ys);		
		string sorted = string.Join(", ", ys);
		if (sorted != merged) "##".Dump();
		string.Concat(sorted == merged ? "Y" : "N", ":", shuffled, "#", merged).Dump();
		if (sorted != merged) "##".Dump();
	}

}


static void Shuffle(int[] arr, int seed){
	for(int i = 0; i < arr.Length; i++){
		int j = new Random(seed).Next(i, arr.Length);
		if (i == j) continue;
		int t = arr[i];
		arr[i] = arr[j];
		arr[j] = t;
	}
}

static int[] MergeSort(int[] arr){
	return MergeSort(arr, 0, arr.Length);
}
static int[] MergeSort(int[] arr, int l, int r){
	if (r-l < 2) {
		return new int[]{ arr[l] };
	}
	int m = (l + r) / 2;
	int[] L = MergeSort(arr, l, m);	
	int[] R = MergeSort(arr, m, r);
	
	return Merge(L, R);
}

static int[] Merge(int[] L, int[] R){
	if (L.Length == 0 || R.Length == 0) return L;
	int[] Z = new int[L.Length+R.Length];
	int z = 0;
	int l = 0;
	int r = 0;
	while(z < Z.Length){
		int a = 0, b = 0;
		bool aok = false, bok = false;
		if (l < L.Length) {
			a = L[l];
			aok = true;
		}
		if (r < R.Length){
			b = R[r];
			bok = true;
		}
		if (aok && (!bok || a < b)){
			Z[z] = a;
			l++;
		}
		else if (bok) {
			Z[z] = b;
			r++;
		}
		z++;
	}
	return Z;
}