void Main()
{
	
	int[] arr = new int[] { 2, 11, 5, 10, 7, 8 };

	TwoSum(arr, 9).Dump();
}


static int[] TwoSum(int[] arr, int target) {

	Array.Sort(arr);
	
	int i=0;
	int j=arr.Length-1;
	
	while(i < j) {
	
		int sum = arr[i]+arr[j];
		if (sum == target) {
			return new int[] {arr[i], arr[j]};
		}
		if (sum < target) {
			i++;
		}
		else {
			j--;
		}
	
	}
	
	return new int[2];

}