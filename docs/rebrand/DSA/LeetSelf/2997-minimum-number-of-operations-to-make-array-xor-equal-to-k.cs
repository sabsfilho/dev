public class Solution {
    public int MinOperations(int[] nums, int k) {	
		int w = k;
		foreach(var n in nums) {
			w = n ^ w;
		}
		var wbits = GetBits(w);
		int q = 0;
		foreach(bool b in wbits){
			if (b) q++;
		}
		return q;
        
    }
	static BitArray GetBits(int i) {
		var bytes = BitConverter.GetBytes(i);
		return new BitArray(bytes);
	}
}