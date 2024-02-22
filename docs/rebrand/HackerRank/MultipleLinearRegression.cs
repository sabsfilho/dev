void Main()
{
	var lns = @"2 7
0.18 0.89 109.85
1.0 0.26 155.72
0.92 0.11 137.66
0.07 0.37 76.17
0.85 0.16 139.75
0.99 0.41 162.6
0.87 0.47 151.77
4
0.49 0.18
0.57 0.83
0.56 0.64
0.76 0.18".Split('\n');


lns = @"6 15
0.87 0.69 0.37 0.22 0.16 0.99 72.38
0.24 0.42 0.23 0.75 0.3 0.56 107.39
0.55 0.54 0.25 0.44 0.02 0.63 74.76
0.39 0.36 0.82 0.99 0.49 0.6 152.03
0.4 0.76 0.52 0.76 0.58 0.03 140.92
0.2 0.43 0.5 0.04 0.12 0.86 68.63
0.74 0.59 0.12 0.65 0.92 0.54 146.89
0.36 0.19 0.01 0.03 0.34 0.79 78.62
0.38 0.49 0.32 0.34 0.31 0.67 96.13
0.07 0.65 0.97 0.03 0.92 0.94 151.32
0.68 0.65 0.52 0.03 0.4 0.45 87.63
0.26 0.82 0.58 0.07 0.99 0.73 146.44
0.29 0.48 0.36 0.29 0.71 0.32 125.81
0.46 0.67 0.7 0.79 0.98 0.88 179.37
0.61 0.2 0.68 0.51 0.31 0.05 108.08
76
0.15 0.39 0.06 0.61 0.33 0.09
0.54 0.14 0.53 0.01 0.93 0.78
0.69 0.74 0.07 0.84 0.13 0.64
0.92 0.04 0.24 0.5 0.19 0.34
0.82 0.03 0.9 0.87 0.4 0.22
0.31 0.21 0.56 0.27 0.83 0.84
0.79 0.83 0.64 0.82 0.39 0.46
0.58 0.37 0.81 0.34 0.77 0.98
0.01 0.9 0.15 0.43 0.9 0.77
0.76 0.76 0.49 0.01 0.95 0.14
0.69 0.31 0.8 0.08 0.36 0.35
0.62 0.63 0.46 0.26 0.01 0.51
0.7 0.91 0.95 0.35 0.47 0.59
0.16 0.16 0.81 0.02 0.04 0.77
0.98 0.85 0.34 0.68 0.74 0.25
0.98 0.86 0.08 0.62 0.25 0.42
0.76 0.78 0.61 0.03 0.02 0.65
0.5 0.07 0.08 0.8 0.23 0.28
0.13 0.42 0.19 0.52 0.94 0.44
0.03 0.89 0.03 0.52 0.37 0.21
0.68 0.5 0.92 0.9 0.66 0.79
0.74 0.7 0.21 0.88 0.4 0.07
0.37 0.8 0.6 0.65 0.86 0.95
0.2 0.32 0.61 0.55 0.52 0.61
0.61 0.93 0.49 0.37 0.59 0.63
0.3 0.07 0.55 0.2 0.72 0.46
0.52 0.74 0.39 0.12 0.16 0.7
0.46 0.82 0.21 0.27 0.2 0.36
0.14 0.48 0.61 0.19 0.81 0.99
0.75 0.93 0.04 0.32 0.65 0.09
0.72 0.75 0.82 0.41 0.17 0.61
0.4 0.92 0.91 0.57 0.47 0.13
0.3 0.9 0.8 0.83 0.25 0.51
0.25 0.61 0.49 0.51 0.18 0.75
0.72 0.82 0.94 0.3 0.91 0.21
0.41 0.49 0.59 0.99 0.58 0.8
0.32 0.25 0.48 0.32 0.38 0.97
0.7 0.61 0.65 0.21 0.31 0.69
0.8 0.48 0.11 0.57 0.26 0.95
0.84 0.22 0.27 0.74 0.26 0.74
0.81 0.61 0.35 0.35 0.43 0.15
0.57 0.36 0.28 0.65 0.97 0.66
0.45 0.43 0.7 0.72 0.03 0.19
0.59 0.09 0.9 0.61 0.89 0.38
0.9 0.66 0.5 0.37 0.27 0.12
0.4 0.28 0.76 0.67 0.89 0.51
0.5 0.91 0.12 0.32 0.16 0.79
0.64 0.96 0.27 0.18 0.11 0.55
0.32 0.79 0.7 0.03 0.87 0.42
0.82 0.2 0.48 0.07 0.11 0.52
0.38 0.77 0.88 0.68 0.41 0.64
0.69 0.03 0.2 0.91 0.85 0.26
0.34 0.15 0.73 0.64 0.39 0.52
0.97 0.25 0.12 0.1 0.08 0.65
0.1 0.96 0.71 0.0 0.37 0.19
0.42 0.89 0.31 0.34 0.35 0.01
0.88 0.78 0.92 0.6 0.3 0.45
0.8 0.02 0.32 0.18 0.05 0.1
0.53 1.0 0.28 0.8 0.04 0.19
0.59 0.02 0.1 0.04 0.56 0.12
0.95 0.27 0.86 0.1 0.67 0.14
0.76 0.43 0.74 0.17 0.89 0.31
0.81 0.33 0.85 0.17 0.21 0.56
0.72 1.0 0.7 0.46 0.79 0.2
1.0 0.67 0.05 0.63 0.68 0.26
0.05 0.83 0.75 0.53 0.5 0.11
0.4 0.56 0.49 0.99 0.02 0.88
0.04 0.23 0.15 0.47 0.73 0.7
0.7 0.25 0.77 0.99 0.65 0.09
0.23 0.22 0.56 0.18 0.43 0.6
0.86 0.05 0.61 0.03 0.75 0.04
0.27 0.58 0.83 0.56 0.43 0.86
0.94 0.17 0.66 0.85 0.06 0.62
0.56 0.03 0.32 0.99 0.79 0.69
0.86 0.03 0.29 0.17 0.57 0.44
0.43 0.16 0.93 0.82 0.25 0.59
".Split('\n');

		int j = 0;
        var xs = lns[j++].Trim().Split(' ');
        int m = int.Parse(xs[0]) + 1;
        int n = int.Parse(xs[1]);
        var ws = new double[n,m]; /* row,col */
        for(int i = 0; i < n; i++)
        {
			var zs = lns[j++].Trim().Split(' ');
			for (int k=0;k<m;k++)
			{
				ws[i,k] = double.Parse(zs[k]);
			}
        }
		var bs = GetBs(ws, n, m);
        var q = int.Parse(lns[j++].Trim());
        for(int i = 0; i < q; i++)
        {
			var zs = lns[j++].Trim().Split(' ');
			var qs = new double[1,m];
			qs[0,0] = 1;
			for (int k=0;k<(m-1);k++)
			{
				qs[0,k+1] = double.Parse(zs[k]);
			}
			var qsbs = Product(qs, bs);
			qsbs.Dump();
        }
}

static double[,] GetBs(double[,] ws, int row, int col)
{
	var xs = new double[row, col];
	var ys = new double[row, 1];
	int coly = col - 1;
	for(int i = 0; i < row; i++)
	{
		xs[i, 0] = 1;
		ys[i, 0] = ws[i, coly];
		for(int j = 0; j < coly; j++)
		{
			xs[i, j + 1] = ws[i, j];			
		}
	}
	var txs = Transpose(xs);
	var txsxs = Product(txs, xs);
	var txsxsInv = Inverse(txsxs);
	var txsxsInvtxs = Product(txsxsInv, txs);
	var txsxsInvtxsys = Product(txsxsInvtxs, ys);
	return txsxsInvtxsys;
}
static Dictionary<string, double> DeterminantDic = new Dictionary<string, double>();
static double Determinant(double[,] xs)
{
	var pkey = MatrixKey(xs);
	double mx;
	if (DeterminantDic.TryGetValue(pkey, out mx))
	{
		return mx;
	}
	double det = 0;
	int r = xs.GetUpperBound(0) + 1;
	if (r == 2)
	{  
		det = xs[0,0] * xs[1,1] - xs[0,1] * xs[1,0];
	}
	else
	{
		int c = xs.GetUpperBound(1) + 1;
		for(int i=0;i<c;i++)
		{
			det += ((double)(-1.0 * (i % 2 == 0 ? -1.0 : 1.0)) * xs[0, i] * Determinant(SubMatrix(xs, 0, i)));
		}
	}
	DeterminantDic.Add(pkey, det);
	return det;
}
static double[,] SubMatrix(double[,] xs, int row, int col)
{
	int r = xs.GetUpperBound(0);
	int c = xs.GetUpperBound(1);
	var ds = new double[r, c];
	int i2 = 0;
	for(int i = 0; i <= r; i++)
	{
		if (i != row)
		{
			int j2 = 0;
			for(int j = 0; j <= c; j++)
			{
				if (j != col)
				{
					ds[i2, j2] = xs[i,j];
					j2++;
				}
			}
			i2++;
		}
	}
	return ds;
}
static Dictionary<string, double[,]> InverseDic = new Dictionary<string, double[,]>();
static double[,] Inverse(double[,] xs)
{
	var pkey = MatrixKey(xs);
	double[,] mx;
	if (InverseDic.TryGetValue(pkey, out mx))
	{
		return mx;
	}
	var k = 1.0/Determinant(xs);
	
	int r = xs.GetUpperBound(0) + 1;
	int c = xs.GetUpperBound(1) + 1;
	var ds = new double[r, c];
	for (int i=0; i < r; i++)
	{
		for(int j=0; j < c; j++)
		{
			ds[i, j] =
				(-1.0 * (((j + i) % 2 == 0) ? -1.0 : 1.0)) * 
				Determinant(SubMatrix(xs, i, j)) *
				k;
		}
	}
	
	InverseDic.Add(pkey, ds);
	
	return ds;
}

static Dictionary<string, double[,]> ProductDic = new Dictionary<string, double[,]>();
static string ProductKey(double[,] xs, double[,] ys)
{
	return string.Concat(MatrixKey(xs), "+", MatrixKey(ys));
}
static double[,] Product(double[,] xs, double[,] ys)
{
	var pkey = ProductKey(xs, ys);
	double[,] mx;
	if (ProductDic.TryGetValue(pkey, out mx))
	{
		return mx;
	}	
	int row = xs.GetUpperBound(0) + 1;
	int colx = xs.GetUpperBound(1) + 1;
	int col = ys.GetUpperBound(1) + 1;
	var ds = new double[row, col];
	for(int i = 0; i < row; i++)
	{
		for(int j = 0; j < col; j++)
		{
			double r = 0;
			for(int k = 0; k < colx; k++)
			{
				r += xs[i,k] * ys[k,j];
			}
			ds[i,j] = r;			
		}
	}
	ProductDic.Add(pkey, ds);
	return ds;
}
static double[,] Transpose(double[,] xs)
{
	int row = xs.GetUpperBound(0) + 1;
	int col = xs.GetUpperBound(1) + 1;
	var ds = new double[col, row];
	for(int i = 0; i < row; i++)
	{
		for(int j = 0; j < col; j++)
		{
			ds[j, i] = xs[i, j];
		}
	}
	return ds;
}

static string MatrixKey(double[,] xs)
{
	string k = string.Empty;
	int row = xs.GetUpperBound(0) + 1;
	int col = xs.GetUpperBound(1) + 1;
	for(int i = 0; i < row; i++)
	{
		for(int j = 0; j < col; j++)
		{
			k = string.Concat(k, k.Length == 0 ? string.Empty : "#", xs[i, j].ToString("f5"));
		}
	}
	return k;
}
