using System;
using System.Linq;
using System.Collections.Generic;

public class RomanNumerals
{
	static Dictionary<int, string> map = new Dictionary<int, string>(){
		{1, "I"},
		{4, "IV"},
		{5, "V"},
		{9, "IX"},
		{10, "X"},
		{40, "XL"},
		{50, "L"},
		{90, "XC"},
		{100, "C"},
		{400, "CD"},
		{500, "D"},
		{900, "CM"},
		{1000, "M"},
		{2000, "MM"},
		{3000, "MMM"}
	};
	
    public static string ToRoman(int n)
    {
		if (n < 1){
			throw new Exception("enter a number greater than or equal to 1");
		}
		else if (n >= 4000){
			throw new Exception("enter a number less than 4000");
		}
		else if (n == 0) {
			return string.Empty;
		}
		
        return 
			Convert(n);
    }
	static int GetZ(int n) {
		int z = -1;
		foreach(var x in map.Keys){
			if (x <= n) z = x;
			else break;
		}
		return z;
	}
	static string Convert(int n){
		if (n == 0) return string.Empty;
		int z = GetZ(n);
		return map[z] + Convert(n - z);
	}

    public static int FromRoman(string romanNumeral)
    {
		var d = 
			map
			.OrderByDescending(x=>x.Value.Length)
			.ThenByDescending(x=>x.Key)
			.ToDictionary(x=>x.Value,x=>x.Key);

		int sum = 0;
		int i = 0;
		int len = romanNumeral.Length;
		while(i < len){		
			int j = 1;
			foreach(var w in d){
				string k = w.Key;
				int l = k.Length;				
				if (
					(len - i - l) >= 0 && 
					k == romanNumeral.Substring(i, l)
				){
					sum += w.Value;
					j = l;
					if (l == 1)
					{
						for(int u=i+j; u < len; u++){
							if (k == romanNumeral.Substring(u, l)){
								j += l;
								sum += w.Value;
							}
							else{
								break;
							}
						}
					}
					break;
				}
			}
			i += j;
		}
		
		return sum;
    }
  }