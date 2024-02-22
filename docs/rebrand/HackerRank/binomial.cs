void Main()
{
	"mean".Dump();
	mean(new double[]{10, 40, 30, 50, 20}).Dump();
	"std.deviation".Dump();
	standardDeviation(new double[]{10, 40, 30, 50, 20}).Dump();
	"factorial of 6".Dump();
	f(6).Dump();
	1253.2346.ToString("f3").Dump();
	//0.891 0.342
	double p = 0.12;
	int times = 10;
	int getting = 2;
	"fair coin tossed 10 times".Dump();
	"getting 5 heads".Dump();
	binomial(getting, times, p).Dump();
	"getting at least 5 heads (x>=5)".Dump();
	cumulativeBinomial(getting, times, times, p).Dump();	
	"getting at most 5 heads (x<=5)".Dump();
	cumulativeBinomial(0, getting, times, p).Dump();
	
	"fifth shot of 70% prob".Dump();
	geomDistr(5, 0.7).Dump();
	
	"prob of 3 homes sold tomorrow of avg 2homes/day".Dump();
	poissonDistribution(2, 3).Dump();
	
	"prob of fewer than 4 lions tomorrow of avg 5 lions/day".Dump();
	cumulativePoissonDistribution(4, 5).Dump();
	
	"poisson random variable 0.88 avg".Dump();
	PoissonRandomVariable(0.88).Dump();
	"NormalDistribution".Dump();
	NormalDistribution(19.5, 20, 2).Dump();
	"CumulativeNormalDistribution".Dump();
	CumulativeNormalDistribution(19.5, 20, 2).Dump();	
	"Pearson".Dump();
	Pearson(ToArr("10 9.8 8 7.8 7.7 7 6 5 4 2"), ToArr("200 44 32 24 22 17 15 12 8 4")).Dump();
	"SpearmanRank".Dump();
	SpearmanRank(ToArr("10 9.8 8 7.8 7.7 1.7 6 5 1.4 2"), ToArr("200 44 32 24 22 17 15 12 8 4")).Dump();
	"LinearRegression".Dump();
	LinearRegression(ToArr("1 2 3 4 5"), ToArr("2 1 4 3 5")).Dump();
}

static double[] ToArr(string xs)
{
    var zs = xs.Trim().Split(' ');
    int l = zs.Length;
    var arr = new double[l];
    int i = -1;
    while(++i<l){
        arr[i] = double.Parse(zs[i]);
    }
	return arr;
}

static double[] LinearRegression(double[] xs, double[] ys)
{
	double n = xs.Length;
	double sumx = 0;
	double sumx2 = 0;
	double meanx = 0;
	double sumy = 0;
	double meany = 0;
	double sumxy = 0;
	for(int i=0; i < n; i++)
	{
		var x = xs[i];
		var y = ys[i];
		sumx += x;
		sumy += y;
		sumx2 += x * x;
		sumxy += x * y;
	}
	meanx = sumx / n;
	meany = sumy / n;
	double b = ( ( n * sumxy ) - ( sumx * sumy ) ) / ( n * sumx2 - ( sumx * sumx ) );
	double a = meany - b * meanx;
	return new double[]{ a, b };
}

static double SpearmanRank(double[] xs, double[] ys)
{
	var rxs = GetRank(xs);
	var rys = GetRank(ys);
	
	int n = xs.Length;
	double r = 0;
	for(int i=0;i<n;i++)
	{
		r += Math.Pow(rxs[i] - rys[i], 2);
	}
	
	return 1.0 - (6 * r) / (n * ( Math.Pow(n, 2) - 1 ));
}

static double[] GetRank(double[] xs)
{
	int n = xs.Length;
	var dic = new SortedDictionary<double, List<int>>();
	for(int i=0;i<n;i++)
	{
		var x = xs[i];
		List<int> ps;
		if (!dic.TryGetValue(x, out ps))
		{
			ps = new List<int>();
			dic.Add(x, ps);
		}
		ps.Add(i);
	}
	var rnks = new double[n];
	int p = 1;
	foreach(var d in dic)
	{
		var ws = d.Value;
		foreach(var w in ws)
		{
			rnks[w] = p;
		}
		p++;
	}
	return rnks;
}

static double Pearson(double[] xs, double[] ys)
{
	var xmn = mean(xs);
	var xstDev = standardDeviation(xs);
	var ymn = mean(ys);
	var ystDev = standardDeviation(ys);
	
	double r = 0;
	int l = xs.Length;
	int i = -1;
	while(++i < l)
	{
		r += ( (xs[i] - xmn) * (ys[i] - ymn) );		
	}
	
	return r / (l * xstDev * ystDev);
}

static double erf (double x) {
    double t = 1 / (1.0 + 0.5 * Math.Abs(x));
    double tau = t * Math.Exp(
            - x * x
            - 1.26551223
            + 1.00002368 * t
            + 0.37409196 * t * t
            + 0.09678418 * t * t * t
            - 0.18628806 * t * t * t * t
            + 0.27886807 * t * t * t * t * t
            - 1.13520398 * t * t * t * t * t * t
            + 1.48851587 * t * t * t * t * t * t * t
            - 0.82215223 * t * t * t * t * t * t * t * t
            + 0.17087277 * t * t * t * t * t * t * t * t * t);
    if (x >= 0) {
        return 1.0 - tau;
    } else {
        return tau - 1.0;
    }
}

static double CumulativeNormalDistribution (double x, double mean, double sdev) {   
    return (0.5 * (1.0 + erf((x - mean) / (sdev * Math.Sqrt(2)))));
}

static double NormalDistribution(double x, double mean, double stdDev){
	double variance = Math.Pow(stdDev, 2);
	double k1 = Math.Pow(x - mean, 2) / (2 * variance);
	double k2 = Math.Pow(Math.E, -k1);
	double k3 = stdDev * Math.Sqrt(2 * Math.PI);
	return k2 / k3;
}

static double PoissonRandomVariable(double avg){
	return (Math.Pow(avg, 2) + avg);
}

static double cumulativePoissonDistribution(int avg, int n){
	double r = 0;
	for(int i = 0; i < avg; i++){
		r += poissonDistribution(i, n);
	}
	return r;
}

static double poissonDistribution(double avg, int n){
	//[ (avg ^ n) * e ^ (-avg) ] / n!
	
	return ( Math.Pow(avg, n) * Math.Pow( Math.E , -avg) ) / f(n);
	

}

static double geomDistr(int n, double p){

	return Math.Pow(1 - p, n - 1) * p;

}

static double cumulativeBinomial(int x, int lim, int n, double p){
	double r = 0;
	
	while(x <= lim){
		r += binomial(x++, n, p);
	}
	
	return r;
}

static double binomial(int x, int n, double p){
	// bn = comb(n, x) * (p ^ x) * (q ^ (n - x))
	// q = 1 - p
	if (n <= x){
		//throw new Exception("n must be greater than x");
		return 0;
	}
	if (p >= 1){
		throw new Exception("p must be less than 1");
	}
	
	double v = comb(n, x) * ( Math.Pow(p, x) ) * ( Math.Pow( 1.0 - p, (n - x) ) );
	
	//string.Concat(x, "=", v).Dump();
	
	return v;
	
}

//combination
static double comb(int n, int r){
	return perm(n, r) / f(r);
}

//permutation
static double perm(int n, int r){
	return f(n) / f(n - r);
}

//factorial
static int f(int v){

	if (v == 0) return 1;

	int r = v;
	
	while(v-->1){
		r = r * v;
	}
	
	return r;

}

static double standardDeviation(double[] arr){
	if (arr.Length == 0) return 0;
	double mn = mean(arr);
	double r = 0;
	foreach(var a in arr){
		r += Math.Pow(a - mn, 2);
	}
	return Math.Sqrt(r / arr.Length);
}

static double mean(double[] arr){
	if (arr.Length == 0) return 0;
	double r = 0;
	foreach(var a in arr){
		r += a;
	}
	return r / arr.Length;
}
