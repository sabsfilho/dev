public class Solution {
    public int LargestAltitude(int[] gain) {
        int mx = 0;
        int h = 0;
        foreach(int g in gain){
            h+=g;
            if (h > mx) mx = h;
        }
        return mx;
    }
}