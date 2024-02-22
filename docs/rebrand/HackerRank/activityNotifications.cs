void Main()
{
	var xs = File.ReadAllLines(@"C:\Users\Owner\Downloads\a.txt").Skip(1).First().Split(' ').Select(x=>int.Parse(x)).ToList();

	activityNotifications(xs, 10000).Dump();
	
	//activityNotifications(new List<int>(){10,20,30,40,50}, 3).Dump();
	//activityNotifications(new List<int>(){20,20,30,40,50}, 4).Dump();

}
    public static int activityNotifications3(List<int> expenditure, int d)
    {
		var srts = expenditure.Take(d).OrderBy(x=>x).ToList();
		
		int q = 0;
		
        bool even = d % 2 == 0;
        int p = Convert.ToInt32(Math.Floor(d/2.0));
		
		for(int i=d;i<expenditure.Count;i++)
		{
			var v = expenditure[i];
			
			double m;
			if (even){
				m = (srts[p] + srts[p-1]) / 2.0;
			}
			else{
				m = srts[p];
			}
            if (v >= 2 * m) 
            {
                q++;
            }
			
			srts.Remove(expenditure[i-d]);
			SortedInsert(srts, v);
		}
		
		return q;
	}
static void SortedInsert(List<int> lst, int v)
{
	int d = lst.Count - 1;
	while(d>1 && v < lst[d])
	{
		d = d / 2;
	}
	if (v > lst[d])
	{
		while(d < lst.Count)
		{
			if (v<=lst[d]){
				break;
			}
			d++;
		}
	}
	else{
		while(d>0 && v <= lst[d])
		{
			if (v>lst[d-1]){
				break;
			}
			d--;
		}
	}
	lst.Insert(d, v);
}
    public static int activityNotifications2(List<int> expenditure, int d)
    {
		var srts = expenditure.Take(d).OrderBy(x=>x).ToList();
		
		int q = 0;
		
        bool even = d % 2 == 0;
        int p = Convert.ToInt32(Math.Floor(d/2.0));
		
		for(int i=d;i<expenditure.Count;i++)
		{
			var v = expenditure[i];
			
			double m;
			if (even){
				m = (srts[p] + srts[p-1]) / 2.0;
			}
			else{
				m = srts[p];
			}
            if (v >= 2 * m) 
            {
                q++;
            }
			
			Update(srts, expenditure[i-d], v);
		}
		
		return q;
	}
	private static void Update(List<int> srts, int rem, int ins)
	{
		if (rem==ins) return;
		srts.Remove(rem);
		
		
	}
    public static int activityNotifications(List<int> expenditure, int d)
    {
		var srts = expenditure.Take(d).OrderBy(x=>x).ToList();
		
        int len = expenditure.Count();
        if (len <= d) return 0;
        
        int q = 0; //answer
        
        bool even = d % 2 == 0;
        int p = Convert.ToInt32(Math.Floor(d/2.0));

        var nums = new int[201]; //sorted.expends
        for(int i=0;i<d;i++)
        {
            int v = expenditure[i];
            nums[v]++;
        }
        int fi = 0; //first expends i
        for(int i=d;i<len;i++)
        {
            int v = expenditure[i]; // curr.v
            
            double m = -1; // medium
            int j=0; //curr.sorted.v
            int k = 0; //prev.sorted.v
            int g = 0; //occurrences
            foreach(var n in nums)
            {
                
                if (n<0)
                {
//Console.WriteLine(string.Concat("j=",j,"k=",k,"n=",n," error!"));
                }
                if (n>0)
                {
                    g+=n;
//Console.WriteLine(string.Concat("j=",j,"k=",k,"n=",n,"g=",g,"p=",p,"v=",v));

                    if (g>p /*|| (g>1&&g==p)*/){
                        if (even&&(n==1||(g-n)==p))
                        {
                            m = (j + k) / 2.0;
//Console.WriteLine(string.Concat("j=",j,"k=",k,"n=",n,"g=",g,"p=",p,"v=",v,"m=",m));
                        }
                        else{
                            m = j;
//Console.WriteLine(string.Concat("j=",j,"k=",k,"n=",n,"g=",g,"p=",p,"v=",v,"m=",m));
                        }
                        break;
                    }
                    k = j;
                }
                j++;
            }
            
            if (m >-1 && v >= 2 * m) 
            {
                q++;
            }
			
			
			
			double m2;
			if (even){
				m2 = (srts[p] + srts[p-1]) / 2.0;
			}
			else{
				m2 = srts[p];
			}
			
			srts.Remove(expenditure[i-d]);
			SortedInsert(srts, v);
			
			if (m!=m2){
			m.Dump();
			m2.Dump();
			}
					
            
            int first = expenditure[fi];
            nums[first]--;
            nums[v]++;
            fi++;
        }
        return q;

    }
