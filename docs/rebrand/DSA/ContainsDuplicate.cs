void Main()
{
	var arr = new int[] {1,2,4,2,3,5,99};	
	
	ContainsDuplicateHashSet(arr).Dump();
	ContainsDuplicateArray(arr).Dump();
}

static bool ContainsDuplicateHashSet(int[] arr) {
	
	var ws = new HashSet<int>();
	int i = 0;
	int j = arr.Length - 1;
	while(i <= j) {
		int a = arr[i];
		int b = arr[j];
		
		if (!ws.Contains(a)){
			ws.Add(a);
		}
		else {
			return true;
		}
		if (i != j) {
			if (!ws.Contains(b)){
				ws.Add(b);
			}
			else {
				return true;
			}
		}
		
		i++;
		j--;
	}	

	return false;

}

static bool ContainsDuplicateArray(int[] arr) {
	
	var ws = new int[arr.Length];
	int i = 0;
	int j = arr.Length - 1;
	int k = 0;
	while(i <= j) {
		int a = arr[i];
		int b = arr[j];
		
		if (Array.IndexOf(ws, a)<0){
			ws[k++] = a;
		}
		else {
			return true;
		}
		if (i != j) {
			if (Array.IndexOf(ws, b)<0){
				ws[k++] = b;
			}
			else {
				return true;
			}
		}		
		i++;
		j--;
	}	

	return false;

}