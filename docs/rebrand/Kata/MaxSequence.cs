
  public static int MaxSequence(int[] arr) 
  { 
  	int max = 0;
  	for(int i = 0; i < arr.Length; i++){
		bool pos = false;
		int sum = 0;
		for(int j = i; j < arr.Length; j++){
			int v = arr[j];
			if (v >= 0) {
				pos = true;
			}
			sum += v;
			if (pos) {
				if (sum > max) {
					max = sum;
				}
			}
		}
		if (sum > max) {
			max = sum;
		}
	}
    return max;
  }