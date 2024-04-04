public class Solution {

    public string Encode(IList<string> strs) {
        return 
            strs == null || strs.Count == 0 ? null :        
            string.Join(";", strs);
    }

    public List<string> Decode(string s) {
        return 
           s == null ? new List<string>() :
            s.Split(";").ToList();
   }
}
