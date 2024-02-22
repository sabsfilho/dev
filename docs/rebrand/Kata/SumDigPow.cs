using System;
using System.Collections.Generic;

public class SumDigPower {
    
    public static long[] SumDigPow(long a, long b) 
    {
		var xs = new List<long>();
		for(long i=a; i<=b; i++){
			if (i == Calc(i)){
				xs.Add(i);
			}
		}
		return xs.ToArray();
    }
	static long Calc(long n){
		long r = 0;
		var x = n.ToString();
		for(int i = 0; i < x.Length; i++){
			r += Convert.ToInt64(Math.Pow(long.Parse(x.Substring(i,1)), i+1));
		}
		return r;
	}
}