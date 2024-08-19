public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        if (n == 0) return true;
        if (flowerbed.Length == 1){
            return n==1 && flowerbed[0]==0;
        }

        for(int i=0; i < flowerbed.Length; i++){
            bool b = flowerbed[i] == 1;
            if (b) continue;
            if (i==0){
                if (flowerbed[i+1]==1) {
                    continue;
                }
            }
            else if (i==flowerbed.Length-1){
                if (flowerbed[flowerbed.Length-2]==1) {
                    continue;
                }
            }
            else if (
                flowerbed[i-1]==1 || 
                flowerbed[i+1]==1
            ) {
                continue;
            }
            flowerbed[i]=1;

            n--;
            if (n == 0) return true;
        }

        return n == 0;
    }
}