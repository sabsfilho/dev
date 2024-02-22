

    public static int ParseInt(string s)
    {
		return Parse(s.ToLower(), 0);
    }
		
	enum K {
		one = 1,
		two = 2,
		three = 3,
		four = 4,
		five = 5,
		six = 6,
		seven = 7,
		eight = 8,
		nine = 9,
		ten = 10,
		eleven = 11,
		twelve = 12,
		thirteen = 13,
		fourteen = 14,
		fifteen = 15,
		sixteen = 16,
		seventeen = 17,
		eighteen = 18,
		nineteen = 19,
		twenty = 20,
        thirty = 30,
		forty = 40,
		fifty = 50,
		sixty = 60,
		seventy = 70,
		eighty = 80,
		ninety = 90,
		hundred = 100,
		thousand = 1000,
		million = 1000000
	};
	
	static List<K> MULTS = new List<K>(){
		K.million,
		K.thousand,
		K.hundred
	};
	
    public static int Parse(string s, int k)
    {
		s = s.Trim();
		
		if (k >= MULTS.Count) {
			var xs = s.Split(' ','-');
			int t = 0;
			foreach(var x in xs){
				K m = 0;
				Enum.TryParse<K>(x, out m);
				t += (int)m;
			}
			return t;
		}
		K mult = MULTS[k];
		string p = mult.ToString();
		int i = s.IndexOf(p);
		int v1 = 0;
		if (i > -1){
			v1 = Parse(s.Substring(0, i), k + 1) * (int)mult;
			i += p.Length;
		}
		else {
			i = 0;
		}
		
		int v2 = Parse(s.Substring(i), k + 1);
		
		return v1 + v2;
    }