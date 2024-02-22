using System.Linq;
public class Kata
{  public static int FindEvenIndex(int[] arr)
  {
  	if (arr.Length == 0) return -1;
	if (arr.Length == 2){
		if (arr[0] == 0) return 1;
		if (arr[1] == 0) return 0;
	}
    int sum = arr.Sum();
	int z = arr[0];  
	if (z == sum) return 0;
	for(int i=1;i<arr.Length;i++){
		int q = arr[i];
		if (z == (sum - z - q)){
			return i;
		}
		z += q;
	}
	return -1;
  }
}