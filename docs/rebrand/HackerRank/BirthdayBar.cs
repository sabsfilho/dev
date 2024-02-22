void Main()
{
	var s = new List<int>{ 1,2,1,3,2 };
	int d = 3;
	int m = 2;
	birthday(s,d,m).Dump();
}

     class K
     {
         public int D = 0;
         public int M = 0;
         
		 int d = 0;
         int m = 0;
		 bool nok = false;
		 public bool isValid(int v)
		 {
		 	if (!nok){
			 	m++;
				d += v;
				if (m == M && d == D){
					nok = true;
					return true;
				}
				else if (m > M || d > D){
					nok = true;
				}
			}
			return false;
		 }
     }

  public static int birthday(List<int> s, int d, int m)
    {
        int len = s.Count;
        var arr = new K[len];
		int q = 0;
        for(int i=0;i<len;i++)
        {
            int v = s[i];
            for(int j=0;j<=i;j++){
				var k = arr[j];
				if (k == null){
					k = new K(){
						M = m,
						D = d
					};
					arr[i] = k;
				}
                if (k.isValid(v)){
					q++;
				}
            }
        }
		return q;
    }
	
	public static int birthday(List<Integer> s, int d, int m) {
    // Write your code here
    
       int count=0;
        for(int i=0;i<=s.size()-m;i++){
            int sum=0;
            for(int j=i;j<i+m;j++){
                sum+=s.get(j);
            }
            if(sum==d){
                count++;
            }
        }
        return count;
    }
