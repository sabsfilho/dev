void Main()
{
	var xs = File.ReadAllLines(@"C:\Users\Owner\Downloads\a.csv");
	int k = int.Parse(xs[0].Split(' ')[1]);
	string s = xs[1];
	s="777";
	k =0 ;
	var z = highestValuePalindrome(s, 0, k);
	z.Dump();
	(z == File.ReadAllText(@"C:\Users\Owner\Downloads\c.csv")).Dump();
}

    public static string highestValuePalindrome(string s, int n, int k)
    {
        int len = s.Length;
        int len2 = s.Length / 2;
		var bs = new bool[len2]; //swappeds
		if (s.Length % 2 != 0)
		{
			len2++;
		}
        var xs = s.ToCharArray();
		int c = k;
        int q = 0;
        for(int i = 0; i < len2; i++)
        {
            int j = len - 1 - i;
            if (i == j)
            {
                q++;
                break;
            }
			if (c == 0 && k > 0)
			{
				break;
			}    
            char a = s[i];
            char b = s[j];
            if (a != b)
            {
				if (k == 0)
				{
					return "-1";
				}
				if (a > b) xs[j] = a;
				else xs[i] = b;
				bs[i] = true;
				c--;
            }
			q+=2;      
        }
		bool isPalindrome = q == len;
		if (isPalindrome && c > 0 && k > 0)
		{
	        for(int i = 0; i < len2; i++)
	        {
	            int j = len - 1 - i;				
	            if (i == j)
	            {
	                if (c > 0)
					{
						xs[i] = '9';
					}
	                break;
	            }				
				
				if (xs[i] == '9')
				{
					continue;
				}
				bool swapped = bs[i];
				if (!swapped && c==1)
				{
					continue;
				}
				xs[i] = '9';
				xs[j] = '9';
				if (swapped) c--;
				else c-=2;
				if (c == 0)
				{
					break;
				}
			}
		}
File.WriteAllText(@"C:\Users\Owner\Downloads\b.csv",new String(xs));
        return isPalindrome ? new String(xs) : "-1";
    }

