    public static int LongestSlideDown(int[][] pyramid)
    {
		int max = 0;
		int[] vs = null;
		for(int i = pyramid.Length - 2; i >= 0; i--){
			int[] ps = pyramid[i];
			
			int[] pds;
				
			if (vs == null) {
				vs = new int[ps.Length];
				pds = pyramid[i+1];
			}
			else {
				vs = vs.Take(ps.Length+1).ToArray();
				pds = vs;
			}
			
			for(int j = 0; j < ps.Length; j++) {
				int mx = new int[2] {
					//j == 0 ? 0 : pds[j-1], /* LEFT */
					pds[j], /* DOWN */
					j == pds.Length - 1 ? 0 : pds[j+1] /* RIGHT */
				}.Max();
				int v = mx + ps[j];
				vs[j] = v;
				if (v > max){
					max = v;
				}
			}
			/*
			string.Concat(i, "=", string.Join(",", pds)).Dump();
			string.Concat(i, "=", string.Join(",", ps)).Dump();
			string.Concat(i, "=", string.Join(",", vs)).Dump();
			*/
		}
	
		return max;
    }