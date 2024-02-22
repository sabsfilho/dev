void Main()
{
	miniMaxSum
}


public static void miniMaxSum(List<int> arr)
    {
        long? min = null;
        long max = 0;

        for(int i=0,l=arr.Count;i<l;i++){
            long v = 0;
            for(int j = 0;j<l;j++){
                if (i!=j){
                    v+=arr[j];
                }
            }
            if (!min.HasValue || v < min){
                min = v;
            }
            if (v > max){
                max = v;
            }
        }

Console.WriteLine(string.Concat(min, " ", max));
    }
