void Main()
{
	int[] xs = new int[7]{ 2,4,1,8,6,3,7 };
	
	FindMissingNumber(xs);	
}

public static int FindMissingNumber(int[] xs){
	//sum of first integral numbers f(n) = n*(n+1)/2 => f(8)=36
		
	Console.WriteLine(string.Join(",", xs));
	
	int n = xs.Length + 1;
	
	int sum = n * (n + 1) / 2;
	
	Console.WriteLine(string.Concat("n=",n,";len=",xs.Length, ";sum=",sum));
	
	for(int i=0; i < xs.Length; i++){
		int x = xs[i];
		sum -= x;
		Console.WriteLine(string.Concat("i=",i,";x=",x, ";sum=",sum));
	}
	
	return sum;
}
