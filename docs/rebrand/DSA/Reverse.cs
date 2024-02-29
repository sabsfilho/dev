void Main()
{
	Reverse(-124934).Dump(); //-439421
}


public static long Reverse(long num) {

	long n = num < 0 ? -num : num;
	
	long r = 0;
	while (n > 0) {
	
		long m = n % 10;
		
		r = r * 10 + m;
	
		n = n / 10;
	}
	
	return num < 0 ? -r : r;

}