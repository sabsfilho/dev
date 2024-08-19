public class Solution {
    public string MergeAlternately(string word1, string word2) {
        int w1 = 0;
        int w2 = 0;

        int wlen1 = word1.Length;
        int wlen2 = word2.Length;
        int len = wlen1 + wlen2;

        char[] r = new char[len];
        int i = 0;
        while(i < len){
            if (w1 < wlen1){
                r[i++] = word1[w1++];
            }
            if (w2 < wlen2){
                r[i++] = word2[w2++];
            }
        }

        return new String(r);
    }
}