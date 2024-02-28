void Main()
{
	//var arr = new int[] { 1,2,3,4,5,6,7 };
	var arr = new int[] { 2,3,5,6,8,9, 10, 11 };
	
	Rearrange(arr);
	
	arr.Dump();
}

static void Rearrange(int[] arr) {

	int j = arr.Length-1;
	var z = new Queue<int>();
	int i = 0;
	for(; i < arr.Length; i++){
		if (arr[i] == -1) break;
		if (i % 2 == 0) {
			z.Enqueue(arr[i]);
			arr[i] = arr[j];
			arr[j] = -1;
			j--;
		}
		else {
			int c = z.Dequeue();
			z.Enqueue(arr[i]);
			arr[i] = c;
		}
	}
	j = 1;
	while(z.Count > 0){
		arr[arr.Length - (j++)] = z.Dequeue();
	}

}
