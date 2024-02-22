
    public static long QueueTime(int[] customers, int n)
    {
		if (n == 1) {
			return customers.Sum();
		}
		
		var ts = new int[n];
		int mini = 0;
		int max = 0;
		foreach(int c in customers){
			int min = int.MaxValue;
			for(int i=0;i<n;i++){
				int t = ts[i];
				if (t < min) {
					min = t;
					mini = i;
				}
			}
			int v = ts[mini] + c;
			ts[mini] = v;
			if (v > max) {
				max = v;
			}
		}
        return max;
    }