public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
        return new List<IList<int>>{
            Filter(nums1, nums2),
            Filter(nums2, nums1)
        };
    }
    static IList<int> Filter(int[] nums1, int[] nums2) {
        return
            nums1
            .Where(x=>!nums2.Contains(x))
            .Distinct()
            .ToList();
    }
}