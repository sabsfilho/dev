void Main()
{
	//ReadCode3("Germany").Dump();
	InsertCountryCode3();
}

// Define other methods and classes here
static string ReadCode3(string country){
	string txt = File.ReadAllText(@"C:\Users\Owner\Downloads\countries.html").ToLower();
	country = string.Concat("\">", country.ToLower(), "</a>");
	int i = txt.IndexOf(country);
	if (i == -1) return null;
	for(int j = i-1; j > 0; j--){
		if (txt[j]=='=') return txt.Substring(j+1, i - j - 1);
	}
	return null;
}

static void InsertCountryCode3(){
	var xs = File.ReadAllLines(@"C:\Users\Owner\Downloads\country0.json").ToList();
	//xs.Take(10).Dump();
	
	List<string> ys = null;
	var zs = new List<string>();
	zs.Add("[");
	int p = 0;
	bool found = false;
	foreach(var x in xs){
		if (x.Contains("  {")){
			ys = new List<string>();
		}
		if (ys == null) continue;
		ys.Add(x);
		if (x.Contains("\"code\"")){
			p = ys.Count;
			ys.Add("");
		}
		else if (x.Contains("\"name\"")){
			int j = x.IndexOf(':');
			if (j == -1) throw new Exception(x + "name not found");
			j+=3;
			string n = x.Substring(j, x.Length-j-1);
			string code3 = ReadCode3(n) ?? "ZZZ";
			Console.WriteLine(string.Concat(n, "=", code3));
			ys[p] = string.Concat("    \"code3\": \"",code3,"\",");
			found = (code3 != "ZZZ");
		}
		else if (x.Contains("  },")){
			if (found) {
				zs.AddRange(ys);
			}
			ys = null;			
		}
	}
	zs.Add("]");
	//zs.Take(10).Dump();
	File.WriteAllLines(@"C:\Users\Owner\Downloads\country_v2.json", zs);
}