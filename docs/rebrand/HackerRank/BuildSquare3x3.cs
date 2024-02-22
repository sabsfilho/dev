void Main()
{
	BuildSquare3x3();
}

static void BuildSquare3x3()
{
	UpdateRow0();
}
static void UpdateRow0()
{
	for(int i = 1; i < 10; i++)
	{
		for(int j = 1; j < 10; j++)
		{
			for (int z = 1; z < 10; z++)
			{
				if (i + j + z == 15)
				{				
					var m = new int[3,3];	
					m[0,0] = i;
					m[0,1] = j;
					m[0,2] = z;					
					UpdateRow1(m);
				}
			}
		}
	}
}
static void UpdateRow1(int[,] mz)
{
	int x = mz[0, 0];
	int y = mz[0, 1];
	int z = mz[0, 2];
	for(int i = 1; i < 10; i++)
	{
		for(int j = 1; j < 10; j++)
		{
			for (int k = 1; k < 10; k++)
			{
				if (
					i + j + k == 15 &&
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
static void UpdateRow2(int[,] mz)
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
					i + j + k == 15 &&
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
					m.Dump();
				}
			}
		}
	}
	
}
