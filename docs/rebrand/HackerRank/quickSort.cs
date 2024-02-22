void Main()
{
	countInversions(new int[]{2,1,3,1,2}).Dump();
}
static int q = 0;
int countInversions(int[] arr)
{
	q = 0;
	quickSort(arr, 0, arr.Length - 1);
	arr.Dump();
	return q;
}

    static void swap(int[] arr, int i, int j)
    {
	string.Concat(arr[i],";", arr[j]).Dump();
        int temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
		q++;
    }
 
    // This function takes last element as pivot,
    // places the pivot element at its correct position
    // in sorted array, and places all smaller to left
    // of pivot and all greater elements to right of pivot
    static int partition(int[] arr, int low, int high)
    {
        // Choosing the pivot
        int pivot = arr[high];
 
        // Index of smaller element and indicates
        // the right position of pivot found so far
        int i = (low - 1);
 
        for (int j = low; j <= high - 1; j++) {
 
            // If current element is smaller than the pivot
            if (arr[j] < pivot) {
 
                // Increment index of smaller element
                i++;
                swap(arr, i, j);
            }
        }
        swap(arr, i + 1, high);
        return (i + 1);
    }
 
    // The main function that implements QuickSort
    // arr[] --> Array to be sorted,
    // low --> Starting index,
    // high --> Ending index
    static void quickSort(int[] arr, int low, int high)
    {
        if (low < high) {
 
            // pi is partitioning index, arr[p]
            // is now at right place
            int pi = partition(arr, low, high);
 
            // Separately sort elements before
            // and after partition index
            quickSort(arr, low, pi - 1);
            quickSort(arr, pi + 1, high);
        }
    }
