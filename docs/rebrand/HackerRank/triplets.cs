void Main()
{
//145333908482693 
var xs = File.ReadAllLines(@"C:\Users\Owner\Downloads\a.txt").Skip(1);
var zs = new List<int[]>();
foreach(var x in xs)
{
	zs.Add(x.Split(' ').Select(z=>int.Parse(z)).ToArray());
}

var q = triplets(zs[0], zs[1], zs[2]);
q.Dump();
(q-145333908482693).Dump();

}

    static long triplets(int[] a, int[] b, int[] c) {
        // p <= q & q >= r
                
        long n = 0;
        
        a = a.Distinct().OrderBy(x=>x).ToArray();
        b = b.Distinct().OrderBy(x=>x).ToArray();
        c = c.Distinct().OrderBy(x=>x).ToArray();
        for(int j = 0; j < b.Length; j++)
        {
            int q = b[j];
            int k = -1;
            //if (c[0] > q) continue;
            //else if (c[c.Length-1] < q) { k = c.Length - 1; k.Dump(); }
            //else {
                k = GetIdx(c, q);
                if (k < 0) {
                    k = (k * -1) - 2;
    //Console.WriteLine(k);
                }
            //}
			int len = a.Length - 1;
            int p = a[len];int i;
            if (p <= q) {k.Dump(); i=len; len.Dump(); GetIdx(a, q).Dump();GetIdx(c, q).Dump();}
			else {
            i = GetIdx(a, q);
            if (i < 0) {
                /*int len = a.Length - 1;
                int p = a[len];
                if (p <= q) { i = len; i.Dump(); }
                else{*/
                    i = Math.Abs(i) - 2;
                //}
                if (i < 0) continue;
            }
		}
            //elems.found.combination
            n += ((long)i+1)*((long)k+1);
//Console.WriteLine(string.Concat("j=",j,"q=",q,"k=",k,"i=",i,"n=",n));
        }

        return n;
    }
    
    static int GetIdx(int[] g, int v)
    {
        //return Array.BinarySearch(g, int index, int length, object value)
        return Array.BinarySearch<int>(g, v);
    }
