public class Solution {
    public int CompareVersion(string version1, string version2) {
        if (version1 == version2) return 0;
        var arr1 = version1.Split('.').Select(x=>int.Parse(x)).ToList();
        var arr2 = version2.Split('.').Select(x=>int.Parse(x)).ToList();
        int d = arr1.Count - arr2.Count;
        if (d != 0) {
            List<int> arr = d < 0 ? arr1 : arr2;
            for(int i = 0; i < Math.Abs(d); i++) {
                arr.Add(0);
            }            
        }
        for(int i = 0; i < arr1.Count; i++) {
            int v1 = arr1[i];
            int v2 = arr2[i];
            if (v1 < v2) return -1;
            else if (v1 > v2) return 1;

        }
        return 0;
    }
}