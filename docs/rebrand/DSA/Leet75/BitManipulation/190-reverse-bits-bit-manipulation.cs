public class Solution {
    public uint reverseBits(uint n) {
        uint r = 0;

        for(int i = 0; i < 32; i++){
            uint bit = (n >> i) & 1;
            r = r | (bit << (31 - i));
        }

        return r;
    }
}