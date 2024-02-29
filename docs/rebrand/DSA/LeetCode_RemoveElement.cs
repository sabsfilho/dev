void Main()
{
	//var nums = new int[] { 3, 2, 2, 3 }; 
	var nums = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }; //2
	RemoveElement(nums, 2);
	nums.Dump();
}

public static int RemoveElement(int[] nums, int val) {
	int i = 0;
	for(int j = 0; j < nums.Length; j++){
		if (nums[j] != val) {
			nums[i] = nums[j];
			i++;
		}
	}
	return i;
}