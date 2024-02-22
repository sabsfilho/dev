void Main()
{
int n = 10000000;/// Convert.ToInt32(Math.Pow(10, 7));
	var qs = Build();//.Take(100).ToList();
	var r = arrayManipulation(n, qs);
	r.Dump();
	(r==2490686975).Dump();
}

// Define other methods and classes here
class T
{
	public int a;
	public int b;
	public long k;
}

    public static long arrayManipulation(int n, List<List<int>> queries)
    {
		var ts = new List<T>();
		var xs = new long[n];

		long max = 0;
		int l = queries.Count;

		for(int j=0;j<l;j++)
		{
			var qs = queries[j];
			var a = qs[0];
			var b = qs[1];
			var k = qs[2];
			if (ts.Count == 0)
			{
				ts.Add(new T(){ a = a, b = b, k = k});
			}
			else
			{
				var xts = new List<T>();
				var rems = new List<T>();
				foreach(var t in ts)
				{
					var ta = t.a;
					var tb = t.b;
					var tk = t.k;
					if (
						b < ta ||
						a > tb
					)
					{
						xts.Add(new T(){ a = a, b = b, k = k});
					}
					else if (
						a == ta &&
						b == tb
					)
					{
						t.k = tk + k;
					}
					else if (a < ta)
					{
						if (b < tb)
						{
						}
					}
				}
			}
			
		}
		
		return max;
    }


static List<List<int>> Build()
{
string[] firstMultipleInput = "10000000 100000".Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int m = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

var x = @"1 2 100
2 5 100
3 4 100
1 2 100".Split('\n');
x = File.ReadAllLines(@"C:\Users\Owner\Downloads\input13.txt");

        for (int i = 0; i < m; i++)
        {
            queries.Add(x[i].Trim().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }
		return queries;
}
