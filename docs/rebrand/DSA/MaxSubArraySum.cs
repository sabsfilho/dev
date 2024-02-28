void Main()
{
	var arr = new int[] { 4, 3, -2, 6, -12, 7, -1, 6 };
	
	MaxSubArraySum(arr).Dump();
}

public int MaxSubArraySum(int[] arr) {

	int maxSoFar = arr[0];
	int currentMax = arr[0];
	
	for(int i=1; i < arr.Length; i++){
		currentMax += arr[i];
		if (currentMax < arr[i]) {
			currentMax = arr[i];
		}
		if (maxSoFar < currentMax) {
			maxSoFar = currentMax;
		}
	}
	
	return maxSoFar;
}