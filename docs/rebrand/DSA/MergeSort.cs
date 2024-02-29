void Main()
{
	var arr = new int[] { 2, 10, 5, 3, 6, 4, 11 };
	
	MergeSort(arr);
	arr.Dump();
}

void MergeSort(int[] arr) {
	Sort(arr, new int[arr.Length], 0, arr.Length - 1);
}

void Sort(int[] arr, int[] temp, int low, int height) {
	if (low < height) {
		int mid = low + (height - low) / 2;
		Sort(arr, temp, low, mid);
		Sort(arr, temp, mid + 1, height);
		Merge(arr, temp, low, mid, height);
	}
}
void Merge(int[] arr, int[] temp, int low, int mid, int height) {
	for(int z = low; z <= height; z++){
		temp[z] = arr[z];	
	}
	int i = low;
	int j = mid + 1;
	int k = low;
	while(i<=mid && j<=height){
		if (temp[i] <= temp[j]){
			arr[k] = temp[i];
			i++;
		}
		else {
			arr[k] = temp[j];
			j++;
		}
		k++;
	}
	while(i<=mid){
		arr[k] = temp[i];
		i++;
		k++;
	}
}