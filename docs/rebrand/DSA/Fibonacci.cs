void Main()
{
	int v = 40;
	
	"FibonacciRecursion".Dump();
	var t = DateTime.Now;
	FibonacciRecursion(v).Dump();
	(DateTime.Now - t).Milliseconds.Dump();
	
	"FibonacciArray-BOTTOM-DOWN".Dump();
	t = DateTime.Now;
	FibonacciArray(v).Dump();
	(DateTime.Now - t).Milliseconds.Dump();
	
	"FibonacciMemo-TOP-DOWN".Dump();
	t = DateTime.Now;
	FibonacciMemo(v, new Dictionary<int,int>()).Dump();
	(DateTime.Now - t).Milliseconds.Dump();
}


public static int FibonacciMemo(int n, Dictionary<int, int> d) {
	if (n < 1) return 0;
	if (n == 1) return 1;
	int v;
	if (d.TryGetValue(n, out v)) return v;
	
	v = 
		FibonacciMemo(n - 1, d) +
		FibonacciMemo(n - 2, d);
	
	d.Add(n, v);
	
	return v;

}


public static int FibonacciRecursion(int n) {
	if (n < 1) return 0;
	if (n == 1) return 1;
	
	return
		FibonacciRecursion(n - 1) +
		FibonacciRecursion(n - 2);

}

public static int FibonacciArray(int n){
	var arr = new int[n + 1];
	
	arr[0] = 0;
	arr[1] = 1;
	
	for(int i = 2; i <= n; i++) {
		arr[i] = arr[i-1] + arr[i-2];
	}
	
	return arr[n];
}