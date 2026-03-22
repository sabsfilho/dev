public class EncodeDecodeStringSolution {
    const string KEY = "##$##";
    const string EMPTY = "????";

    public string Encode(IList<string> strs) {
        if (strs.Count == 0) strs.Add(EMPTY);
        return string.Join(KEY ,strs);
    }

    public List<string> Decode(string s) {
        var xs = s.Split(KEY).ToList();
        if (xs.Count == 1 && xs[0] == EMPTY) return new List<string>();
        return xs;
   }
}
