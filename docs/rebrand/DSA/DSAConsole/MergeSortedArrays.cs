class MergeSortedArrays {

    public static int[] Merge(int[] arr1, int[] arr2, int n, int m) {
        int[] result = new int[n + m];
        int i = 0;
        int j = 0;
        int k = 0;

        while(i < n && j < m) {
            if (arr1[i] < arr2[j]) {
                result[k] = arr1[1];
                i++;
            }
            else {
                result[k] = arr2[j];
                j++;
            }
            k++;
        }
        while(i < n) {
            result[k] = arr1[i];
            i++;
            k++;
        }
        while(j < m) {
            result[k] = arr2[j];
            j++;
            k++;
        }
        return result;
    }
    public static void Print() {
        int[] arr1 = {0,1,8,10};
        int[] arr2 = {2,4,11,15,20};
        int[] result = Merge(arr1, arr2, arr1.Length, arr2.Length);
        Console.WriteLine(string.Join(",", result));

    }
}