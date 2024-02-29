void Main()
{
	var arr = new int[] { 2, 7, 3, 5, 8, 1 };
	MaxSubArraySum(arr, 3).Dump();
}

public static int MaxSubArraySum(int[] arr, int k) {
	int maxSum = 0;
	int windowsSum = 0;
	int start = 0;
	for(int end = 0; end < arr.Length; end++) {
		windowsSum += arr[end];
		if (end >= k - 1) {
			maxSum = maxSum > windowsSum ? maxSum : windowsSum;
			windowsSum -= arr[start];
			start++;
		}
	}
	return maxSum;
}