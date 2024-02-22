void Main()
{
//2318
//23331668
		int n = 1000000000;
		int k = 100;
		CalcLong(n-1, k).Dump();
}

static long CalcLong(int n, int k)
{
	if (n > k){
		int d = n % k;
		int q = (n / k);
		long sum = 0;
		int z = 0;
		for(int i = 1; i <= q; i++){
			int y = i*k-1;			
			sum += Calc(y, z);
			z = y;
		}
		if (d!=0){
			sum += Calc(q*k+d, z);
		}
		return sum;
	}
	return Calc(n, 0);
}

static long Calc(int n, int k)
{
	if (n <= k) return 0;

    long sum = 0;
	if (n == 3){
		return n;
	}
	
	if (n % 3 == 0 || n % 5 == 0){
		sum = n;
	}
	sum += Calc(n-1, k);
	return sum;
}
