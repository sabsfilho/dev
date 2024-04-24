public class Solution {
    public bool CheckValidString(string s) {
        //control open char min , max        
        //if open then min++, max++
        //if close then min--, max--
        //if * then min--, max++
        //if min < 0 then 0
        //if max < 0 then return false
        //return min == 0
        int min = 0; //open
        int max = 0; //close;

        foreach(char c in s){
            if (c == '('){
                min++;
                max++;
            }
            else if (c == ')'){
                min--;
                max--;
            }
            else {
                min--;
                max++;
            }
            if (max < 0) return false;
            if (min < 0) min = 0;
        }
        return min == 0;
    }
}