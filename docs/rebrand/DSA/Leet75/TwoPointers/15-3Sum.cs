void Main()
{
	var xs = new int[]{ 0,0,0,0,0,0,-1,0,1,2,-1,-4 };
	new Solution().ThreeSum(xs).Dump();
}

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
	
		var lst = new List<IList<int>>();
	
		Array.Sort(nums);
		
		for(int i=0; i < nums.Length-2; i++){
			int a = nums[i];
			if (i > 0 && nums[i-1]==a) continue;
			int left = i+1;
			int right = nums.Length-1;
			while(left < right){
				int b = nums[left];
				int c = nums[right];
				int bc = b+c;
				if (bc==-a){
					lst.Add(new List<int>(){a,b,c});
					while(left < right && nums[left] == nums[left+1]) left++;
					while(left < right && nums[right] == nums[right-1]) right--;
					left++;
					right--;
				}
				else if (bc > -a){
					right--;
				}
				else {
					left++;
				}
				
			}
		}
	
		return lst;
    }
}