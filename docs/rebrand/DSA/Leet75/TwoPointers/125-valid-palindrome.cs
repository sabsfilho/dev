public class Solution {
    public bool IsPalindrome(string s) {
        int j = s.Length - 1;
        for(int i = 0; i < s.Length; i++){
            char a = GetChar(s[i]);
            if (a == '@') continue;

            char b = GetChar(s[j--]);
            if (b == '@') {
                i--;
                continue;
            }
            if (a != b) return false;
        }
        return true;
    }
    static char GetChar(char a){
        if (a >= 'A' && a <= 'Z'){
            return (char)((int)a + 32);
        }
        else if (
            (a >= 'a' && a <= 'z') ||
            (a >= '0' && a <= '9')
        ){
            return a;
        }
        return '@';
    }
}