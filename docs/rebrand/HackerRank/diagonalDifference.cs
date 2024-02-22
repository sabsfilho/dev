void Main()
{
	diagonalDifference(List<List<int>> arr)
}

// Define other methods and classes here
 
    public static int diagonalDifference(List<List<int>> arr)
    {
        int a = 0;
        int b = 0;
        for(int i=0,l=arr.Count;i<l;i++){
            var xs = arr[i];
            for(int j=0;j<xs.Count;j++){
                var v = xs[j];
                if(i==j){
                  a+=v;  
                }
                if ((l - i - 1)==j){
                    b+=v;
                }
            }
        }
        return Math.Abs(a-b);
    }
