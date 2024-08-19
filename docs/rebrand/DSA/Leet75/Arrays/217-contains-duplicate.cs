public class Solution {
    public bool ContainsDuplicate2(int[] nums) {
        Array.Sort(nums);
        for(int i=1;i<nums.Length;i++){
            if (nums[i-1]==nums[i]) return true;
        }
        return false;
    }
	public bool ContainsDuplicate(int[] nums) {
		var z = new HashSet<int>();
		foreach(var x in nums){
			if (z.Contains(x)) return true;
			z.Add(x);
		}
		return false;
    }
}