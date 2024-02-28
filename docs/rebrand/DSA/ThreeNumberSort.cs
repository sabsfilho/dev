void Main()
{
	var xs = new int[] { 2, 0, 2, 2, 0, 1, 1 };
	/*var ys = new List<int>();
	for(int i=0;i<1000000;i++){
		ys.AddRange(xs);
	}
	xs = ys.ToArray();*/
	//var t = DateTime.Now;
	ThreeNumberSort(xs);
	//ThreeNumberSort2(xs);
	//(DateTime.Now - t).Milliseconds.Dump();
	xs.Dump();
}

static void ThreeNumberSort(int[] arr) {
	int i = 0;
	int j = 0;
	int k = arr.Length-1;
	while(i <= k) {
		if (arr[i] == 0) {
			Swap(arr, i, j);
			i++;
			j++;
		}
		else if (arr[i] == 1) {
			i++;
		}
		else if (arr[i] == 2) {
			Swap(arr, i, k);
			k--;
		}
	}
}
static void Swap(int[] arr, int i, int j){
	int t = arr[i];
	arr[i] = arr[j];
	arr[j] = t;
}

static void ThreeNumberSort2(int[] xs) {
	int z = 0;
	int o = 0;
	int t = 0;
	
	foreach(var x in xs) {
		switch(x) {
			case 0:
				z++;
				break;
			case 1:
				o++;
				break;
			case 2:
				t++;
				break;			
		}
	}
	
	for(int i=0;i<z;i++) xs[i] = 0;
	for(int i=z;i<z+o;i++) xs[i] = 1;
	for(int i=z+o;i<xs.Length;i++) xs[i] = 2;
	
}