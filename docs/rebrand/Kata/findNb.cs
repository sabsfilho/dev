using System;
using System.Collections.Generic;

public class ASum {
	
	public static long findNb(long m) {
		int n = 1;
		var d = new Dictionary<int, long>();
		while(true){
			long v = fn(n, d);
			if (v == m){
				return n;
			}
			else if (v > m) {
				return -1;
			}
			n++;
		}
	}
	
	public static long fn(int n, Dictionary<int, long> d){
		long r = 0;
		if (d.TryGetValue(n, out r)){
			return r;
		}
		r += Convert.ToInt64(Math.Pow(n, 3));
		if (n > 1) {
			r += fn(n-1, d);
		}
		d.Add(n, r);
		return r;
	}
	
}
