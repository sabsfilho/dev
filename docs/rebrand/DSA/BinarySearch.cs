void Main()
{
        

	//var xs = new int[]{ 1, 2, 13, 24, 25, 36, 37 };
	var xs = new int[]{ 1, 2 };
	
	BinarySearch(xs, 1).Dump();

}

static int BinarySearch(int[] arr, int v){

	Array.Sort(arr);
	int i = 0;
	int j = arr.Length - 1;
	while(i <= j){
		int k = (i + j) / 2;
		
		int a = arr[k];
		if (v == a) {
			return k;
		}
		if (v > a) {
			i = k + 1;
		}
		else {
			j = k - 1;
		}
	}
	return -1;
}