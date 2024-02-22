void Main()
{
	lonelyinteger(new List<int>(){1,2,3,4,3,2,1}).Dump();
}

// Define other methods and classes here
 public static int lonelyinteger(List<int> a)
    {
		var xs = new List<int>();
		foreach(var x in a){
			if (xs.Contains(x)){
				xs.Remove(x);
			}
			else{
				xs.Add(x);
			}
		}
		return xs[0];
    }
