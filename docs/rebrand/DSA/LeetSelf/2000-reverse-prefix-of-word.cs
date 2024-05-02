public class Solution {
    public string ReversePrefix(string word, char ch) {

        int i = word.IndexOf(ch);
        if (i == -1) return word;
        string x = word.Substring(0, i+1);
        //Console.WriteLine(x);
        string y = word.Substring(i+1);
        //Console.WriteLine(y);
        var arr = x.ToCharArray();
        Array.Reverse(arr);
        var w = new String(arr);
        //Console.WriteLine(w);

        return string.Concat(
            w,
            y
        );
        
    }
}