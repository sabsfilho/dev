void Main()
{
	
}


    public static int birthdayCakeCandles(List<int> candles)
    {
        int q = 0;
        int h = 0;
        for(int i=0,l=candles.Count;i<l;i++)
        {
            var a = candles[i];
            if (a > h){
                h = a;
                q = 1;
            }
            else if (a == h){
                q++;
            }
        }
        return q;

    }
