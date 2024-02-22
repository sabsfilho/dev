void Main()
{
	
var qs = new List<int>(){ 8,7,6,5,4,3,2,1 };	
	insertionSort2(qs.Count, qs);
	
	/*

	8 7 6 5 4 3 2 1
	
7 8 6 5 4 3 2 1
6 7 8 5 4 3 2 1
5 6 7 8 4 3 2 1
4 5 6 7 8 3 2 1
3 4 5 6 7 8 2 1
2 3 4 5 6 7 8 1
1 2 3 4 5 6 7 8


	
	1, 4, 3, 5, 6, 2 
	
1 4 3 5 6 2 
1 3 4 5 6 2 
1 3 4 5 6 2 
1 3 4 5 6 2 
1 2 3 4 5 6
	
	3,4,7,5,6,2,1 
3 4 7 5 6 2 1
3 4 7 5 6 2 1
3 4 5 7 6 2 1
3 4 5 6 7 2 1
2 3 4 5 6 7 1
1 2 3 4 5 6 7
	*/
}

// Define other methods and classes here
public static void insertionSort2(int n, List<int> arr)
{
	for(int i=1;i<arr.Count-1;i++)
	{
		var x = arr[i];
		for(int j=i-1;j>=0;j--)
		{
			var y = arr[j];
			var z = j == 0 ? 0 : arr[j - 1];
		Console.WriteLine( string.Join(" ", arr) ); 
		bool b = y > x && z <= x;
			Console.WriteLine(string.Concat(z,"=",y,"[",j,"]=",x,"[",i,"]", b?"ok":"nok" ) ); 
			if (b){
				if ((i-j)>1){
				arr[i] = y;
				arr[j] = x;	
				}				
			}
		}
		Console.WriteLine( string.Join(" ", arr) ); 
	}
	insertionSort1(n, arr);
		Console.WriteLine( string.Join(" ", arr) ); 
}
    public static void insertionSort1(int n, List<int> arr)
    {        
		int len = arr.Count;
        
        var z = arr.Last();
        int h=0;
        for(int i = 1; i < len; i++)
        {
			int y = len - i;
			
			int j = y - 1;
			
			if (j >= 0)
			{		
				bool print = false;
				var a = arr[j];				
				if (a < z) {
					if (z < arr[y+1]){
						arr[y] = z;
	        			print = true;
					}
				}
				else {
					arr[y] = a;
				}
			}
		
        }
		
		if (arr[0]>z){
			arr[0] = z;
		}
    }
