/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {

        int l = 0;
        int r = n;
        while(l <= r && l <= n && r >= 0){
            int m = l + ((r - l) / 2);
            int g = guess(m);
            if (g == 0) return m;
            if (g > 0) l = m + 1;
            else r = m - 1;
            //Console.WriteLine($"l={l} r={r} m={m} g={g}");
        }

        return 0;
    }
}