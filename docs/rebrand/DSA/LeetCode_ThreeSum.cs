void Main()
{
	var arr = new int[] { 2, 4, 3, 7, 1, 8, 9, 0 };	
	//6 = {0,2,4} {1,2,3}
	
	ThreeSum(arr, 6).Dump();
}

// Define other methods and classes here

public static List<int[]> ThreeSum(int[] arr, int n) {
	
	var rs = new List<int[]>();
	
	Array.Sort(arr);
	
	for(int i = 0; i < arr.Length; i++) {
		int j = i + 1;
		int k = arr.Length - 1;
		while(j < k) {
			int sum = arr[i] + arr[j] + arr[k];
			if (sum == n) {
				rs.Add(new int[]{ arr[i], arr[j], arr[k] });
				j++;
				k--;
			}
			else if (sum < n) {
				j++;
			}
			else {
				k--;
			}
		}
	}
	
	return rs;
	
}