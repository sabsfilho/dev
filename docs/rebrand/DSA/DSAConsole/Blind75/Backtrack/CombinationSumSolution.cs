public class CombinationSumSolution {
// Combination Sum
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var lst = new List<List<int>>();
        if (nums == null || nums.Length == 0) return lst;
        Array.Sort(nums);
        Backtrack(nums, target, 0, new List<int>(), lst);
        return lst;
    }

    private void Backtrack(int[] nums, int target, int start, List<int> current, List<List<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(current));
            return;
        }

        for (int i = start; i < nums.Length; i++) {
            if (nums[i] > target) break;
            current.Add(nums[i]);
            Backtrack(nums, target - nums[i], i, current, result);
            current.RemoveAt(current.Count - 1);
        }
    }
}