
  public static int[] ArrayDiff(int[] a, int[] b)
  {
    Array.Sort(b);
    
  	var xs = new List<int>();
	
    foreach(var x in a){
      if (Array.BinarySearch(b, x) < 0) {
        xs.Add(x);
      }
    }
	
  	return xs.ToArray();
  }