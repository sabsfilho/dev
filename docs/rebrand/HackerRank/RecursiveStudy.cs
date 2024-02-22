void Main()
{
	Exponential(5, 3).Dump();
}
static int Exponential(int n, int p)
{
n.Dump();
	if (p < 2) {
		return n;
	}
	else{
		return n * Exponential(n, p - 1);
	}
}
static int Summation(int n)
{
	if (n <= 0) {
		return 0;		
	}
	else{
		return n + Summation(n - 1);
	}
}
static int Factorial(int n)
{
	if (n <= 0) {
		return 1;		
	}
	else{
		return n * Factorial(n - 1);
		/*int v = n * Factorial(n - 1);
		string.Concat(n, "=", v).Dump();
		return v;*/
	}
}
