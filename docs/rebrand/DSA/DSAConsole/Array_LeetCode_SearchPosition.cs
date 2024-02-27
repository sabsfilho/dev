class Array_LeetCode_SearchPosition{
    private static int BinarySearch(int[] arr, int n){

        int i = 0;
        int j = arr.Length - 1;

        while(i <= j){
            int m = i + (j-i)/2;
            if (arr[m] == n) return m;
            if (n < arr[m]){
                j = m - 1;
            }
            else {
                i = m + 1;
            }
        }

        return i;
    }

    private static void BubbleSort(int[] arr, int n){
        bool isSwapped = false;
        for(int i=0; i < n-1; i++) {
            isSwapped = false;
            for(int j=0; j < n - 1 - i;j++) {
                if (arr[j] > arr[j+1]) {
                    int t = arr[j];
                    arr[j] = arr[j+1];
                    arr[j+1] = t;
                    isSwapped = true;
                }
            }
            if (isSwapped == false) {
                break;
            }
        }

    }
    private static void InsertSort(int[] arr, int v){
        for(int i=0; i < arr.Length; i++){
            int t = arr[i];
            int j = i - 1;
            while(j >=0 && arr[j] > t) {
                arr[j+1] = arr[j];
                j--;
            }
            arr[j+1] = t;
        }

    }
    public static void Print(){
        int[] arr = {1,3,5,7};
        int[] ns = {5,2,8,0};

        foreach(var n in ns){
            int v = BinarySearch(arr, n);
            Console.WriteLine($"n:{n};v:{v}");
        }

        int[] arr2 = {5, 1, 2, 9, 10};
        BubbleSort(arr2, arr2.Length);
        InsertSort(arr2, 3);
        Console.WriteLine(string.Join(",", arr2));


    }
}