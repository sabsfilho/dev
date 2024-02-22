void Main()
{
	//var qs = Build();
var qs = new List<int>(){ 2,3,4,5,6,7,8,9,10,1 };	
	insertionSort1(qs.Count, qs);
	//calc(5, qs);
	
	/*
var qs = new List<int>(){ 2,4,6,8,3 };	
2 4 6 8 8 
2 4 6 6 8 
2 4 4 6 8 
2 3 4 6 8


var qs = new List<int>(){ 2,3,4,5,6,7,8,9,10,1 };	

2 3 4 5 6 7 8 9 10 10
2 3 4 5 6 7 8 9 9 10
2 3 4 5 6 7 8 8 9 10
2 3 4 5 6 7 7 8 9 10
	*/
}

// Define other methods and classes here

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
				//string.Join(" ", arr).Dump();
				//string.Concat(a,">",arr[y],"[",y,"]+",y==9?0:arr[y+1]).Dump();
					arr[y] = a;
        			print = true;
				}
				if (print){
					Console.WriteLine( string.Join(" ", arr) ); 
				}
			}
		
        }
		
		if (arr[0]>z){
			arr[0] = z;
			Console.WriteLine( string.Join(" ", arr) );    
		}
		
		//File.WriteAllLines(@"C:\Users\Owner\Downloads\rtn.txt", rtn.Distinct());
        
        
    }

static List<int> Build()
{
        List<int> queries = new List<int>();

return "2 4 8 12 15 19 21 24 26 29 30 32 35 36 41 44 49 52 57 58 59 64 65 68 73 77 80 82 85 88 93 97 101 105 108 111 115 118 122 127 130 131 132 134 135 136 138 141 144 146 151 153 158 160 165 169 171 176 179 184 187 190 194 197 200 205 210 215 217 222 225 230 231 236 239 243 244 246 248 253 254 256 258 262 263 267 272 274 277 280 284 285 289 291 295 297 301 305 310 312 279"
.Split(' ')
.Select(x=>int.Parse(x))
.ToList();

	
}
