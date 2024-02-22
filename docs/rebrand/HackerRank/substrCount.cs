void Main()
{    
	var s = "mnonopoo";//12
	s="asasd";//7
	s="abcbaba";//10
	s="aaaa";//10
	
	substrCount(s.Length, s).Dump();
}

// Define other methods and classes here
    static long substrCount(int n, string s) {
        long q = n;
		char a = s[0];
		int seq = 1;
		int seqp = 0;
		bool isaba = false;
		int i2 = -1;
		for(int i=1;i<n;i++)
		{
			char c = s[i];
			if (c == a)
			{
				q+=seq;
				seq++;
				if (isaba)
				{
					if (seq < seqp)
					{
						q++;
					}
					else
					{
						isaba = false;
					}
				}
			}
			else
			{
				if (i == i2)
				{
					q++;
				}
				else
				{
					isaba = false;
				}
				
				if (i < (n-1) && a == s[i+1])
				{
					seqp = seq + 1;
					isaba = true;
					i2 = i + 1;
				}
				seq = 1;
			}
			a = c;
		}
		
		return q;
    }
