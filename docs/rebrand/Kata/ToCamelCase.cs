using System;
using System.Linq;

public class Kata
{
  public static string ToCamelCase(string str)
  {
  	return
		string.Join(
			string.Empty,
	    	str.Split('-','_')
			.Select((x,i)=> i == 0 ? x : string.Concat(x.Substring(0,1).ToUpper(), x.Substring(1)))
		);
  }
}