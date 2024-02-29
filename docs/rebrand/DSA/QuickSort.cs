void Main()
{
	var arr = new int[] { 3, 1, 4, 9, 2, 5 };
	Sort(arr, 0, arr.Length-1);
	arr.Dump();
}

static void Sort(int[] arr, int low, int high){
	if (low < high) {
		int p = Partition(arr, low, high);
		Sort(arr, low, p-1);
		Sort(arr, p, high);
	}
}

static int Partition(int[] arr, int low, int high){
	int pivot = arr[high];
	int i = low;
	int j = low;
	while(i <= high){
		if (arr[i] <= pivot) {
			int t = arr[i];
			arr[i] = arr[j];
			arr[j] = t;
			j++;
		}
		i++;
	}	
	return j - 1;
}