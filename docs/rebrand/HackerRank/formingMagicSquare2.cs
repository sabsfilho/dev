void Main()
{
var x = @"4 5 8
2 4 1
1 9 7"; // 14

x = @"4 9 2
3 5 7
8 1 6"; // 0

x = @"4 1 5
7 6 4
7 2 2"; //21

var s = x.Split('\n').Select(y=>y.Split(' ').Select(u=>int.Parse(u)).ToList()).ToList();

formingMagicSquare(s).Dump();
}
static int formingMagicSquare(List<List<int>> s)
{
	var o = new MagicSquare3x3(s);	
	o.Magic.Dump();
	return o.Number;
}

public class MagicSquare3x3
{
	int[,] magic = null;
	int min = 0;
	List<List<int>> square;
	public MagicSquare3x3(List<List<int>> s)
	{
		if (!IsMagicSquare(s))
		{	
			square = s;
			UpdateRow0();
		}
	}
	
	/* get magic number */
	public int Number { get	{ return min; } }
	
	/* get magic square */
	public int[,] Magic { get { return magic; } }

	void UpdateRow0()
	{
		/*BRUTEFORCE 3X3*/
		for(int i = 1; i < 10; i++)
		{
			for(int j = 1; j < 10; j++)
			{
				for (int k = 1; k < 10; k++)
				{
					if (
						i + j + k == 15 &&
						IsAllDistinct(i, j, k) // all distinct, thanks michael_chen !!!
					)
					{				
						var m = new int[3,3];	
						m[0,0] = i;
						m[0,1] = j;
						m[0,2] = k;					
						UpdateRow1(m);
					}
				}
			}
		}
	}
	
	static bool IsAllDistinct(int i, int j, int k)
	{
		return
			i != j && 
			i != k && 
			j != k;
	}
	
	static bool IsDistinct(int v, int x, int y, int z)
	{
		return
			v != x &&
			v != y &&
			v != z;
	}
	
	void UpdateRow1(int[,] mz)
	{
		int x = mz[0, 0];
		int y = mz[0, 1];
		int z = mz[0, 2];
		for(int i = 1; i < 10; i++)
		{
			if (!IsDistinct(i, x, y, z))
			{
				continue;
			}
			for(int j = 1; j < 10; j++)
			{
				if (!IsDistinct(j, x, y, z))
				{
					continue;
				}
				for (int k = 1; k < 10; k++)
				{
					/*MAGICSQUARE FILTER FOR ROW 1*/
					if (
						i + j + k == 15 &&
						IsDistinct(k, x, y, z) &&
						IsAllDistinct(i, j, k) && 
						15-x-i < 10 &&
						15-y-j < 10 &&
						15-z-k < 10 &&
						15-x-j < 10 &&
						15-z-j < 10
					)
					{	
						var m = new int[3,3];
						m[0,0] = x;
						m[0,1] = y;
						m[0,2] = z;
						
						m[1,0] = i;
						m[1,1] = j;
						m[1,2] = k;
						
						UpdateRow2(m);
					}
				}
			}
		}
		
	}
	
	void UpdateRow2(int[,] mz)
	{
		int x = mz[0, 0] + mz[1, 0];
		int y = mz[0, 1] + mz[1, 1];
		int z = mz[0, 2] + mz[1, 2];
		for(int i = 1; i < 10; i++)
		{
			for(int j = 1; j < 10; j++)
			{
				for (int k = 1; k < 10; k++)
				{
					if (
						/*MAGICSQUARE FILTER*/
						i + j + k == 15 &&
						IsDistinct(k, x, y, z) &&
						x + i == 15 &&
						y + j == 15 &&
						z + k == 15 &&
						mz[0,0] + mz[1,1] + k == 15 &&
						mz[0,2] + mz[1,1] + i == 15
					)
					{	
						var m = new int[3,3];					
						m[0,0] = mz[0,0];
						m[0,1] = mz[0,1];
						m[0,2] = mz[0,2];
						
						m[1,0] = mz[1,0];
						m[1,1] = mz[1,1];
						m[1,2] = mz[1,2];
						
						m[2,0] = i;
						m[2,1] = j;
						m[2,2] = k;
						
						Compare(m);
					}
				}
			}
		}	
	}
	
	void Compare(int[,] m)
	{
		/* compare matrix to get minimum value */
		int sum = 0;
		int r = 0;		
		foreach(var cs in square)
		{
			int c = 0;
			foreach(var v in cs)
			{
				sum += Math.Abs(v - m[r, c]);
				c++;
			}
			r++;
		}
		if (min == 0 || sum < min)
		{
			min = sum;
			//min.Dump();
			//m.Dump();
			magic = m;
		}
	}
	
	static bool IsMagicSquare(List<List<int>> s)
	{
		int n = s.Count;
		int k = n * (n*n + 1) / 2;
		var cols = new int[n];
		var rows = new int[n];
		int dg1s = 0;
		int dg2s = 0;
		int r = 0;
		int c = 0;
		foreach(var cs in s)
		{
			c = 0;
			foreach(var v in cs)
			{
				cols[c] += v;
				rows[r] += v;
				if (c==r)
				{
					dg1s += v;
				}
				if (n-r-1==c)
				{
					dg2s += v;
				}
				c++;
			}
			r++;
		}
		if (
			dg1s == k &&
			dg2s == k &&
			cols.All(x=>x==k) &&
			rows.All(x=>x==k)
		)
		{
			return true;
		}
		return false;
	}
}
