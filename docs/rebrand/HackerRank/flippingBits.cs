void Main()
{
	long n = 2147483647;
	n = 9;
	//ToBinary(n).Dump();		
	flippingBits(n).Dump();
}
    public static long flippingBits(long n)
    {
        double z = 0;
        var bs = new bool[32];
        int i = 31;
        while(n > 0)
        {
            bs[i--] = n % 2L == 1;
            
            n = n / 2L;
        }
        for(i = 0; i < 32; i++)
        {
            if (!bs[i])
            {
                z += Math.Pow(2, 31 - i);
            }
        }
        return Convert.ToUInt32(z);
    }
