void Main()
{
	//var arr = new int[] { 1, 1, 2 };
	var arr = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
	
	RemoveDuplicates(arr);
	
	arr.Dump();
}

public static int RemoveDuplicates(int[] arr){

	int j = 1;
	for(int i=1; i < arr.Length; i++) {
	
		if (arr[i-1] != arr[i]) {
			arr[j] = arr[i];
			j++;
		}
		else {
			arr[i] = arr[j];
		}
	}
	return j;

}