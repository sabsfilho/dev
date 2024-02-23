void Main()
{
	int[] xs = new int[8]{ 8,1,0,0,2,1,0,3 };
	
	MoveZeros(xs);
	
	Console.WriteLine(string.Join(",", xs));
}

public static void MoveZeros(int[] xs){
	
	int j = 0;
	for(int i=0; i < xs.Length; i++){
		if (xs[i] != 0 && xs[j] == 0){
			int t = xs[i];
			xs[i] = xs[j];
			xs[j] = t;
		}
		if (xs[j] != 0){
			j++;
		}
		
		Console.WriteLine(string.Concat("i=",i,";j=",j, "#",string.Join(",", xs)));
	}
	
}
