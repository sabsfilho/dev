public class Solution {
    public string ReverseVowels(string s) {
        var vs = new char[]{
            'a', 'e', 'i', 'o', 'u',
            'A', 'E', 'I', 'O', 'U'
        };
        int len = s.Length-1;
        var cs = s.ToCharArray();
        int l=0;
        int r=len;
        bool bl = false;
        bool br = false;
        while(l<r && l<=len && r >= 0) {
            if (bl && br) {
                //swap
                //Console.WriteLine($"blbr l={cs[l]} r={cs[r]}");
                char c = cs[r];
                cs[r] = cs[l];
                cs[l] = c;
                l++;
                r--;
                if (r<0 || l>len) break;
                bl = false;
                br = false;
            }
            if (!bl) {
                char lc = cs[l];
                //Console.WriteLine($"l={l} {lc}");
                if (!vs.Contains(lc)) l++;
                else bl = true;
            }
            if (!br) {
                char rc = cs[r];
                //Console.WriteLine($"r={r} {rc}");
                if (!vs.Contains(rc)) r--;
                else br = true;
            }
        }
        return new String(cs);
    }
}