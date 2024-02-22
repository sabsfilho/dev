//Last-digit-of-a-huge-number
namespace Solution {
  using System;
  using System.Numerics;
  
  public class Calculator {
    public static int LastDigit(int[] array) {
//Console.WriteLine(string.Join(",",array));
      // Euler’s totient concept

	BigInteger e = 1;
	for(int i=array.Length-1;i>=0;i--){
		int a = array[i];
		if (e == 0) {
			e = 1;
		}
		else if (a == 0) {
			e = 0;
		}
		else if (e == 1) {
			e = a;
		}
		else {
            int m = (int)BigInteger.Remainder(e,4) + 4;
	    	e = BigInteger.Pow(a, m);
		}
	}
	    return (int)BigInteger.Remainder(e,10);
    }
    
    
  }
}