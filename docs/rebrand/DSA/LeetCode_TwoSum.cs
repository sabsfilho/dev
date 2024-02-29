void Main()
{
	int[] arr = new int[] { 2, 11, 5, 10, 7, 8 };

	TwoSum(arr, 9).Dump();
}

static int[] TwoSum(int[] arr, int target) {

	int[] rs = new int[2];
	
	var d = new Dictionary<int, int>();
	
	for(int i = 0; i < arr.Length; i++){
		if (!d.ContainsKey(target-arr[i])){
			d.Add(arr[i], i);
		}
		else {
			rs[1] = i;
			rs[0] = d[target-arr[i]];
			return rs;
		}
	}
	
	return rs;

}