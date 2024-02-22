using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static List<string> GetPINs(string observed)
    {
		return GetPINs(observed, new Dictionary<string,List<string>>());
	}
    static List<string> GetPINs(string observed,Dictionary<string,List<string>> d)
    {
		if (observed.Length == 1){
			switch(observed[0]){
				case '0':
					return "0,8".Split(',').ToList();
				case '1':
					return "1,2,4".Split(',').ToList();
				case '2':
					return "1,2,3,5".Split(',').ToList();
				case '3':
					return "2,3,6".Split(',').ToList();
				case '4':
					return "1,4,5,7".Split(',').ToList();
				case '5':
					return "2,4,5,6,8".Split(',').ToList();
				case '6':
					return "3,5,6,9".Split(',').ToList();
				case '7':
					return "4,7,8".Split(',').ToList();
				case '8':
					return "0,5,7,8,9".Split(',').ToList();
				case '9':
					return "6,8,9".Split(',').ToList();
				default:
					return new List<string>();
			}
		}
		
		List<string> xs;
		if (d.TryGetValue(observed, out xs)) {
			return xs;
		}
		
		var xs1 = GetPINs(observed[0].ToString(), d);
		
		var xs2 = GetPINs(observed.Substring(1), d);
		
		xs = new List<string>();
		foreach(var x in xs1){
			foreach(var y in xs2){
				xs.Add(string.Concat(x, y));
			}
		}
		
		d.Add(observed, xs);
	
        return xs;
		
    }
}