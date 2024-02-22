void Main()
{

	for(int i = 1; i <= 10; i++)
	{
		Print(i);
	}
	
	Print(125);

Print(439);
Print(999);
"1111100111".Length.Dump();
CountOnes(439).Dump();
ToInt("110110111").Dump();
ToInt("1011").Dump();
}

static void Print(int i)
{
	string.Concat(i, "=", ToBinary(i)).Dump();
}

static int ToInt(string x)
{
	double n = 0;
	for(int i = 0, len = x.Length; i < len; i++)
	{
		if (x[i] == '1')
		{
			n += Math.Pow(2, len - i - 1);
		}
	}
	return Convert.ToInt32(n);
}

static string ToBinary(int n)
{
	string x = string.Empty;
	while(n > 0)
	{
		x = string.Concat((n % 2), x);
		n = n / 2;
	}
	return x;
}

static int CountOnes(int n)
{
	int count = 0;
	int max = 0;
	while(n > 0)
	{
		int rem = (n % 2);
		if (rem == 1)
		{
			count++;
		}
		else
		{
			if (count > max)
			{
				max = count;
			}
			count = 0;
		}
		n = n / 2;
	}
	return max > count ? max : count;
}


static bool[] ToBinary(short x)
{
	/* short = 16 bits */
	var bs = new List<bool>();
	
	while(x>0)
	{
		bs.Insert(0, x%2==1);		
		x = (short) (x / 2);
	}
	var bslen = bs.Count;
	var arr = new bool[16];
	Array.Copy(bs.ToArray(), 0, arr, arr.Length - bslen, bslen);	
	return bs.ToArray();
}

static uint ToInt(bool[] bs)
{
	double r = 0;
	
	for(int i=0, len=bs.Length; i<len; i++)
	{
		if (bs[i])
		{
			r += Math.Pow(2, len - i - 1);
		}
	}
	
	return Convert.ToUInt32(r);
}
