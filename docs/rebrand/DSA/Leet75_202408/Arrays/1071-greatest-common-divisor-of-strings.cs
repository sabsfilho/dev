public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if (str1 == str2) return str1;
        //longest must be equal to shortest at beginning
        string mnstr, mxstr;
        if (str1.Length > str2.Length) {
            mnstr = str2;
            mxstr = str1;
        }
        else {
            mnstr = str1;
            mxstr = str2;
        }
        var pfxs = new List<string>();
        for(int i = 0; i < mnstr.Length; i++){
            //different escape
            if (mxstr[i] != mnstr[i]) return string.Empty;
            int j = i + 1;
            //divisible save
            //Console.WriteLine($"{mxstr.Length} {j} {mnstr.Length}");
            if (mnstr.Length % j == 0) {
                if (j*2 > mxstr.Length) continue;                
                var nxt = mxstr.Substring(j, j);
                var pfxj = mxstr.Substring(0, j);
                if (nxt != pfxj) continue;
                pfxs.Add(pfxj);
            }
        }
        //only divisible and length sorted
        pfxs = pfxs
            .Where(x => mxstr.Length % x.Length == 0)
            .OrderBy(x=>x.Length)
            .ToList();
        //no matches escape
        if (pfxs.Count == 0) return string.Empty;
        //Console.WriteLine(string.Join(";", pfxs));
        string pfx = pfxs.Last();        
        //if (mxstr.Length % pfx.Length != 0) return string.Empty;
        //check prefix until the longest end
        for (int i = mnstr.Length; i < mxstr.Length; i+=pfx.Length){
            //no matches escape
            if (mxstr.Substring(i, pfx.Length) != pfx) return string.Empty;
        }
        
        return pfx;

    }
}