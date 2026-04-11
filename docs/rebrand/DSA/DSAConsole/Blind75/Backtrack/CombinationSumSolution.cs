public class CombinationSumSolution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var lst = new List<List<int>>();

        Dfs(lst, 0, new List<int>(), nums, target);

        return lst;        
    }

    void Dfs(List<List<int>> lst, int i, List<int> curr, int[] nums, int target)
    {
        if (i == nums.Length || target < 0) return;

        if (target == 0)
        {
            lst.Add(curr.ToList());
            return;
        }

        int n = nums[i];

        curr.Add(n);

        Dfs(lst, i, curr, nums, target - n);

        curr.RemoveAt(curr.Count-1); // backtracking

        Dfs(lst, i + 1, curr, nums, target);

    }
}
